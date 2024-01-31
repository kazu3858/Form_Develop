//-------------------------------------------------------------------------------------
//Table.cs
//
//Membersテーブルを表示、データ削除処理を行うフォーム
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
    public partial class Table : Form {
        public Table() {
            InitializeComponent();
            // フォームを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;
        }
      
        /// <summary>
        /// メニュー画面へ遷移する処理
        /// </summary>
        private void BackDisplay(object sender, EventArgs e) {

            this.Close();

        }

        /// <summary>
        /// 入力したIDに準ずるデータを削除する処理
        /// </summary>
        private void DeleteData(object sender, EventArgs e) {

            // テキストボックスの入力を確認
            if (string.IsNullOrWhiteSpace(deleteTextBox.Text)) {
                MessageBox.Show("削除するデータを選択してください。");
                return;  // テキストボックスが空の場合、削除処理を中断
            }

            // 確認メッセージを表示
            DialogResult result = MessageBox.Show("選択したデータを削除しますか？", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {

                // テキストボックスの入力を取得
                int selectedUserId = Convert.ToInt32(deleteTextBox.Text);

                // SQLiteデータベースに接続するための文字列
                string connectionString = "Data Source=myDataBase.db;Version=3;";

                // SQLiteデータベースへの接続を作成
                using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                    try {

                        connection.Open();

                        // Usersテーブルからデータを削除するSQLクエリを実行
                        string deleteQuery = "DELETE FROM Members WHERE ID = @ID";
                        using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, connection)) {

                            deleteCommand.Parameters.AddWithValue("@ID", selectedUserId);
                            deleteCommand.ExecuteNonQuery();

                        }

                        // データを再読み込みしてDataGridViewに表示
                        DataSearch_Click(sender, e);

                    } catch (Exception ex) {

                        // エラーが発生した場合の処理
                        MessageBox.Show("データの削除中にエラーが発生しました: " + ex.Message);

                    } finally {

                        // データベース接続を閉じる
                        connection.Close();

                    }
                }
            }
        }

        /// <summary>
        /// データベース接続後、グリッドビューにMembersテーブルを表示する処理
        /// </summary>
        private void DataSearch_Click(object sender, EventArgs e) {
            // SQLiteデータベースに接続するための文字列
            string connectionString = "Data Source=myDataBase.db;Version=3;";

            // SQLiteデータベースへの接続を作成
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {

                // SQLiteコマンドを作成してクエリを実行するための準備
                string query = "SELECT * FROM Members";

                SQLiteCommand command = new SQLiteCommand(query, connection);

                // データを取得するためのデータアダプターを作成
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                // データを格納するためのデータセット
                DataSet dataSet = new DataSet();

                // データをデータセットに取得し、データグリッドビューに表示(例外処理)
                try {

                    //データベースへ接続
                    connection.Open();

                    // Membersテーブルからデータを取得するクエリを実行
                    adapter.Fill(dataSet);

                    // 取得したデータをDataGridViewに表示する
                    dataGridView2.DataSource = dataSet.Tables[0];

                } catch (Exception ex) {

                    // データ取得中にエラーが発生した場合の処理
                    MessageBox.Show("データの取得中にエラーが発生しました: " + ex.Message);

                } finally {

                    // データベース接続を閉じる
                    connection.Close();

                }
            }
        }
    }
}