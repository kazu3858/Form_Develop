//-------------------------------------------------------------------------------------
//AdminEntry.cs
//
//管理者情報をUsersテーブルに登録するスクリプト
//
//
//作成日1月26日
//更新日1月29日
//作成者:中村将吾
//-------------------------------------------------------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Form_Develop {
    public partial class AdminEntry : Form {
        public AdminEntry() {
            InitializeComponent();
            // フォームを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// パスワードの形式検証メソッド
        /// </summary>
        /// <param name="password">パスワード</param>
        private bool IsValidPassword(string password) {

            // 正規表現を使用して英字、数字、および記号のみを許可するパターンを指定
            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(password, pattern);

        }

        /// <summary>
        /// 管理者情報登録処理
        /// </summary>
        private void RegisterButtonClick(object sender, EventArgs e) {

            // SQLite接続文字列
            string connectionString = "Data Source=myDatabase.db;Version=3;";
            // ユーザー名、パスワードを取得
            string username = UserNameText.Text;
            string password = PasswordText.Text;           

            // 入力検証
            if (string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password)) {

                MessageBox.Show("ユーザー名、パスワードを入力してください");

                // 検証に失敗した場合は処理を終了
                return;
            }

            try {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                    // SQLコマンドオブジェクトの作成
                    using (SQLiteCommand command = new SQLiteCommand(connection)) {
                        // パラメーターの追加
                        command.CommandText = "INSERT INTO Users (Username, Password)"+ "VALUES (@Username,@Password)";
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                                          
                        // コマンドの実行
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("管理者情報が正常に登録されました。");

            } catch {
                // エラーメッセージを表示
                MessageBox.Show("データベースへの登録中にエラーが発生しました。");
            } finally {
                this.Close(); // フォームを閉じてメイン画面に戻る
            }
        }
        /// <summary>
        /// メイン画面へ遷移する処理
        /// </summary>       
        private void BuckWindowsButtonClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}
