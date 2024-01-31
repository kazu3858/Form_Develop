
namespace Form_Develop
{
    partial class MainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableCheck = new System.Windows.Forms.Button();
            this.memberRegiButton = new System.Windows.Forms.Button();
            this.memberInfoChenge = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminChengeButton = new System.Windows.Forms.Button();
            this.adminList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(655, 400);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(133, 38);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "終了";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(141, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "交通系ICカード管理";
            // 
            // tableCheck
            // 
            this.tableCheck.Location = new System.Drawing.Point(319, 248);
            this.tableCheck.Name = "tableCheck";
            this.tableCheck.Size = new System.Drawing.Size(133, 55);
            this.tableCheck.TabIndex = 4;
            this.tableCheck.Text = "会員情報一覧";
            this.tableCheck.UseVisualStyleBackColor = true;
            this.tableCheck.Click += new System.EventHandler(this.TableCheck);
            // 
            // memberRegiButton
            // 
            this.memberRegiButton.Location = new System.Drawing.Point(99, 248);
            this.memberRegiButton.Name = "memberRegiButton";
            this.memberRegiButton.Size = new System.Drawing.Size(140, 55);
            this.memberRegiButton.TabIndex = 6;
            this.memberRegiButton.Text = "会員情報登録";
            this.memberRegiButton.UseVisualStyleBackColor = true;
            this.memberRegiButton.Click += new System.EventHandler(this.MemberRegiButton);
            // 
            // memberInfoChenge
            // 
            this.memberInfoChenge.Location = new System.Drawing.Point(535, 248);
            this.memberInfoChenge.Name = "memberInfoChenge";
            this.memberInfoChenge.Size = new System.Drawing.Size(133, 55);
            this.memberInfoChenge.TabIndex = 7;
            this.memberInfoChenge.Text = "会員情報変更";
            this.memberInfoChenge.UseVisualStyleBackColor = true;
            this.memberInfoChenge.Click += new System.EventHandler(this.MemberInfoChenge);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(250, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(133, 31);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "管理者ログイン";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(111, 12);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(133, 31);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "管理者登録";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(667, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(133, 31);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "ログアウト";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton);
            // 
            // adminChengeButton
            // 
            this.adminChengeButton.Location = new System.Drawing.Point(389, 12);
            this.adminChengeButton.Name = "adminChengeButton";
            this.adminChengeButton.Size = new System.Drawing.Size(133, 31);
            this.adminChengeButton.TabIndex = 11;
            this.adminChengeButton.Text = "管理者情報変更";
            this.adminChengeButton.UseVisualStyleBackColor = true;
            this.adminChengeButton.Click += new System.EventHandler(this.AdminInfoChenge);
            // 
            // adminList
            // 
            this.adminList.Location = new System.Drawing.Point(528, 12);
            this.adminList.Name = "adminList";
            this.adminList.Size = new System.Drawing.Size(133, 31);
            this.adminList.TabIndex = 12;
            this.adminList.Text = "管理者一覧";
            this.adminList.UseVisualStyleBackColor = true;
            this.adminList.Click += new System.EventHandler(this.AdminListButton);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminList);
            this.Controls.Add(this.adminChengeButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.memberInfoChenge);
            this.Controls.Add(this.memberRegiButton);
            this.Controls.Add(this.tableCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tableCheck;
        private System.Windows.Forms.Button memberRegiButton;
        private System.Windows.Forms.Button memberInfoChenge;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button adminChengeButton;
        private System.Windows.Forms.Button adminList;
    }
}

