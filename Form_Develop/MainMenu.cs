//-------------------------------------------------------------------------------------
//MainMenu.cs
//
//メニュー画面からの遷移やプログラムを終了するプログラム
//
//作成日11月10日
//更新日1月29日
//作成者:中村将吾
//-------------------------------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace Form_Develop {
    public partial class MainMenu : Form {
        private bool _isLoggedIn;
        private LoginForm _loginForm;
        public MainMenu(bool isLoggedIn, LoginForm loginForm) {
            InitializeComponent();

            // フォームを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;
            _isLoggedIn = isLoggedIn;
            _loginForm = loginForm;
        }

        /// <summary>
        /// 会員プログラム終了処理するメソッド
        /// </summary>
        private void CloseButton(object sender, EventArgs e) {
            // ユーザーに確認ダイアログを表示
            DialogResult result = MessageBox.Show("終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ユーザーが「はい」を選択した場合のみ終了処理を実行
            if (result == DialogResult.Yes) {
                this.Close(); // フォームを終了
            }
        }

        /// <summary>
        /// 会員テーブル表示画面に遷移するメソッド
        /// </summary>
        private void TableCheck(object sender, EventArgs e) {
            Form form = new Table();
            this.Hide(); // MeinMenuを非表示にする

            if (form.ShowDialog() == DialogResult.Cancel) {
                this.Show(); // Table.csを表示する
            }
        }

        /// <summary>
        /// 会員情報入力フォームに遷移するメソッド
        /// </summary>
        private void MemberRegiButton(object sender, EventArgs e) {
            Form form = new MemberEntry();

            if (form.ShowDialog() == DialogResult.Cancel) {
                this.Show(); // MemberEntry.csを表示する
            }
        }

        /// <summary>
        /// 会員情報変更フォームに遷移するメソッド
        /// </summary>
        private void MemberInfoChenge(object sender, EventArgs e) {
            Form form = new MemberInfo();

            if (form.ShowDialog() == DialogResult.Cancel) {
                this.Show(); // MemberInfo.csを表示する
            }
        }

        /// <summary>
        /// ログインフォームに遷移するメソッド
        /// </summary>
        private void LoginButton(object sender, EventArgs e) {
            if (_isLoggedIn) {
                MessageBox.Show("既にログインしています。");
            } else {
                this.Hide();
                LoginForm loginForm = new LoginForm(_isLoggedIn);

                // LoginForm が閉じられたときにログイン状態を取得
                if (loginForm.ShowDialog() == DialogResult.OK) {
                    _isLoggedIn = true; // ログインが成功した場合、ログイン状態を更新

                }

                // LoginForm が閉じられたときにメインメニューフォームを再表示
                this.Show();
            }
        }

        /// <summary>
        /// 新規管理者登録フォームに遷移するメソッド
        /// </summary>
        private void RegisterButton(object sender, EventArgs e) {
            Form form = new AdminEntry();
            this.Hide(); // MainMenu.csを非表示にする

            if (form.ShowDialog() == DialogResult.Cancel) {
                this.Show(); // AdominEntry.csを表示する
            }
        }

        /// <summary>
        /// 管理者情報変更フォームに遷移するメソッド
        /// </summary>
        private void AdminInfoChenge(object sender, EventArgs e) {
            Form form = new AdminInfo();
            this.Hide(); // MainMenu.csを非表示にする

            if (form.ShowDialog() == DialogResult.Cancel) {
                this.Show(); // AdominInfo.csを表示する
            }
        }
        /// <summary>
        /// ログアウト処理を行うメソッド
        /// </summary>
        private void LogoutButton(object sender, EventArgs e) {
            // ログアウトボタンがクリックされたときの処理
            if (_isLoggedIn) {
                _isLoggedIn = false;               

                // ログアウトしたことをユーザーに通知
                MessageBox.Show("ログアウトしました。");
            } else {
                // すでにログアウトしている場合の処理
                MessageBox.Show("すでにログアウトしています。");
            }
        }

        /// <summary>
        /// 管理者一覧フォームに遷移するメソッド
        /// </summary>
        private void AdminListButton(object sender, EventArgs e) {
            Form form = new UsersTable();
            this.Hide(); // MainMenuを非表示にする

            if (form.ShowDialog() == DialogResult.Cancel) {
                this.Show(); // UserTable.csを表示する
            }
        }
    }
}