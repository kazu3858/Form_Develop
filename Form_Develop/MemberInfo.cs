//-------------------------------------------------------------------------------------
//MemberInfo.cs
//
//会員情報検索、変更をするスクリプト
//
//
//作成日11月2日
//更新日1月26日
//作成者:中村将吾
//-------------------------------------------------------------------------------------
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Form_Develop {
    public partial class MemberInfo : Form {

        public MemberInfo() {
            InitializeComponent();
            // フォームを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 会員情報を変更する処理
        /// </summary>
        private void InfoChange(object sender, EventArgs e) {
            // 新しい会員情報を取得
            string newFirstName = firstNameBox.Text;
            string newLastName = lastNameBox.Text;
            string newAddress = addressBox.Text;
            string newNumber = numberTextBox.Text;

            // テキストボックスが空かどうかを確認
            if (string.IsNullOrWhiteSpace(newFirstName) || string.IsNullOrWhiteSpace(newLastName) ||
                string.IsNullOrWhiteSpace(newAddress) || string.IsNullOrWhiteSpace(newNumber)) {

                MessageBox.Show("すべてのフィールドを入力してください。変更を中止します。");
                return;
            }

            // SQLiteデータベースに接続するための文字列
            string connectionString = "Data Source=myDataBase.db;Version=3;";

            // SQLiteデータベースへの接続を作成
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                try {
                    connection.Open();

                    // 入力されたIDを取得
                    int searchId = Convert.ToInt32(searchTextBox.Text);

                    // Membersテーブルのデータを更新するSQLクエリを実行
                    string updateQuery = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber WHERE ID = @ID";
                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection)) {
                        updateCommand.Parameters.AddWithValue("@FirstName", newFirstName);
                        updateCommand.Parameters.AddWithValue("@LastName", newLastName);
                        updateCommand.Parameters.AddWithValue("@Email", newAddress);
                        updateCommand.Parameters.AddWithValue("@PhoneNumber", newNumber);

                        // IDを指定する
                        updateCommand.Parameters.AddWithValue("@ID",searchId);

                        updateCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("会員情報が更新されました。");
                    this.Close();
                } catch (Exception ex) {
                    MessageBox.Show("データの更新中にエラーが発生しました: " + ex.Message);
                } finally {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 会員情報を検索する処理
        /// </summary>
        private void SearchData(object sender, EventArgs e) {

            // テキストボックスの入力を確認
            if (string.IsNullOrWhiteSpace(searchTextBox.Text)) {

                MessageBox.Show("検索するIDを入力してください。");
                return;

            }

            // 入力されたIDを取得
            int searchId = Convert.ToInt32(searchTextBox.Text);

            // SQLiteデータベースに接続するための文字列
            string connectionString = "Data Source=myDataBase.db;Version=3;";

            // SQLiteデータベースへの接続を作成
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                try {
                    connection.Open();

                    // Membersテーブルから特定のIDのデータを取得するSQLクエリを実行
                    string searchQuery = "SELECT * FROM Members WHERE ID = @ID";

                    using (SQLiteCommand searchCommand = new SQLiteCommand(searchQuery, connection)) {
                        searchCommand.Parameters.AddWithValue("@ID", searchId);

                        // データを取得するためのデータアダプターを作成
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(searchCommand);

                        // データを格納するためのデータセット
                        DataSet dataSet = new DataSet();

                        // データをデータセットに取得
                        adapter.Fill(dataSet);

                        // データが見つかった場合、結果をテキストボックスに表示
                        if (dataSet.Tables[0].Rows.Count > 0) {
                            DataRow row = dataSet.Tables[0].Rows[0];
                            firstNameBox.Text = row["FirstName"].ToString();
                            lastNameBox.Text = row["LastName"].ToString();
                            addressBox.Text = row["Email"].ToString();
                            numberTextBox.Text = row["PhoneNumber"].ToString();

                            MessageBox.Show("検索が成功しました。");

                        } else {

                            // データが見つからなかった場合の処理
                            MessageBox.Show("指定されたIDのデータが見つかりませんでした。");

                        }
                    }
                } catch (Exception ex) {

                    MessageBox.Show("データの検索中にエラーが発生しました: " + ex.Message);

                } finally {

                    connection.Close();

                }
            }
        }

        /// <summary>
        /// メインメニュー画面へ戻る処理
        /// </summary>       
        private void BuckButton(object sender, EventArgs e) {

            //このフォームを閉じる
            this.Close();

        }
    }
}

