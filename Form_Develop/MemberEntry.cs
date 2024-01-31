//-------------------------------------------------------------------------------------
//MemberEntry.cs
//
//会員情報をMembersテーブルに登録するスクリプト
//
//
//作成日11月2日
//更新日1月26日
//作成者:中村将吾
//-------------------------------------------------------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Form_Develop {
    public partial class MemberEntry : Form {
        public MemberEntry() {
            InitializeComponent();
            // フォームを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 電話番号の形式検証メソッド
        /// </summary>
        /// <param name="phoneNumber">電話番号</param>
        private bool IsValidPhoneNumber(string phoneNumber) {

            // 正規表現を使用して数字のみを許可するパターンを指定
            string pattern = "^[0-9]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);

        }

        /// <summary>
        /// メールアドレスの形式検証メソッド
        /// </summary>
        /// <param name="email">メールアドレス</param>
        private bool IsValidEmail(string email) {

            // 正規表現を使用して英字、数字、および記号のみを許可するパターンを指定
            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// 会員情報登録処理
        /// </summary>     
        private void RegisterButton_Click(object sender, EventArgs e) {

            // SQLite接続文字列
            string connectionString = "Data Source=myDatabase.db;Version=3;";

            // 氏名、メールアドレス、電話番号を取得
            string firstname = firstNameText.Text;
            string lastname = lastNameText.Text;
            string address = addressText.Text;
            string phone = numberText.Text;

            // 入力検証
            if (string.IsNullOrWhiteSpace(firstname)
                || string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone)) {

                MessageBox.Show("氏名、メールアドレス、電話番号をすべて入力してください。");

                // 検証に失敗した場合は処理を終了
                return;
            }

            // 電話番号の形式検証（英字、数字、記号のみ）
            if (!IsValidPhoneNumber(phone)) {
                MessageBox.Show("電話番号は数字のみを含めてください。");
                return;
            }

            // メールアドレスの形式検証（英字、数字、記号のみ）
            if (!IsValidEmail(address)) {
                MessageBox.Show("メールアドレスは英数字、および記号のみを含めてください。");
                return;
            }

            try {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                    // SQLコマンドオブジェクトの作成
                    using (SQLiteCommand command = new SQLiteCommand(connection)) {
                        // パラメーターの追加
                        command.CommandText = "INSERT INTO Members " +
                            "(FirstName, LastName, Email, PhoneNumber, RegistrationDate) " +
                            "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @RegistrationDate)";
                        command.Parameters.AddWithValue("@FirstName", firstname);
                        command.Parameters.AddWithValue("@LastName", lastname);
                        command.Parameters.AddWithValue("@Email", address);
                        command.Parameters.AddWithValue("@PhoneNumber", phone);

                        // 現在の日時を登録
                        command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                        // コマンドの実行
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("会員情報が正常に登録されました。");

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
        private void BackToMainButton_Click(object sender, EventArgs e) {
            this.Close(); // フォームを閉じる
        }
    }
}