//-------------------------------------------------------------------------------------
//LoginForm.cs
//
//ログインフォーム
//
//
//作成日1月26日
//更新日1月29日
//作成者:中村将吾
//-------------------------------------------------------------------------------------
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Form_Develop {
    public partial class LoginForm : Form {
        private bool _isLoggedIn;

        public LoginForm(bool isLoggedIn) {
            InitializeComponent();
            // フォームを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;
            _isLoggedIn = isLoggedIn;
        }

        /// <summary>
        /// ログイン処理
        /// </summary>
        private void LoginButtonClick(object sender, EventArgs e) {
            // ユーザーが入力したユーザー名とパスワードを取得
            string username = UserNameText.Text;
            string password = PasswordText.Text; 

            // 入力が空でないか確認
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("ユーザー名とパスワードを入力してください。");
                return;
            }

            // データベース接続文字列
            string connectionString = "Data Source=myDataBase.db;Version=3;";

            // SQLiteデータベースへの接続
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                try {
                    connection.Open();

                    // ユーザーの認証を行うSQLクエリ
                    string query = "SELECT ID FROM Users WHERE Username = @Username AND Password = @Password";

                    // SQLコマンドの作成
                    using (SQLiteCommand command = new SQLiteCommand(query, connection)) {
                        // パラメータの追加
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // クエリの実行結果を取得
                        object result = command.ExecuteScalar();

                        // 認証成功
                        if (result != null) {
                            MessageBox.Show("ログイン成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _isLoggedIn = true; // ログイン状態を更新
                            DialogResult = DialogResult.OK; // ログイン成功を示す
                            this.Close();
                        } else {
                            MessageBox.Show("ユーザー名またはパスワードが正しくありません。", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // 例外が発生した場合の処理
                catch (Exception ex) {
                    MessageBox.Show("ログイン中にエラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // 必ず接続を閉じる
                finally {
                    // connection.Close(); // ここでクローズする必要はありません
                }
            }
        }
        /// <summary>
        /// ログイン処理
        /// </summary>
        private void BuckMenu(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel; // キャンセルボタンが押されたことを示す
            this.Close();
        }
    }
}