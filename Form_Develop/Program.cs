//-------------------------------------------------------------------------------------
//Program.cs
//
//SQLiteを使用してテーブルを作成する
//テーブル内容:Users,Members
//
//作成日11月2日
//更新日1月26日
//作成者:中村将吾
//-------------------------------------------------------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Form_Develop {
    public static class Program {
        [STAThread]
        private static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // SQLite接続文字列
            string connectionString = "Data Source=myDatabase.db;Version=3;";

            // SQLite接続オブジェクトの作成
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                connection.Open();
                // テーブル作成用のSQLクエリ
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL
                    )";

                // SQLコマンドオブジェクトの作成
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection)) {
                    // テーブルの作成を実行
                    command.ExecuteNonQuery();
                }
                // Membersテーブル作成用のSQLクエリ
                string createMembersTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Members (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        PhoneNumber TEXT,
                        RegistrationDate DATETIME NOT NULL
                    )";
                // Membersテーブルの作成を実行
                using (SQLiteCommand command = new SQLiteCommand(createMembersTableQuery, connection)) {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            // LoginForm を作成
            LoginForm loginForm = new LoginForm(false);

            // MainMenu を起動する際にログイン状態を指定し、LoginForm を渡す
            Application.Run(new MainMenu(false, loginForm));

        }
    }
}