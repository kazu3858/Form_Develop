
namespace Form_Develop {
    partial class AdminInfo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buckWindowsButton = new System.Windows.Forms.Button();
            this.adminSearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adminPassText = new System.Windows.Forms.TextBox();
            this.adminNameText = new System.Windows.Forms.TextBox();
            this.adminChengeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buckWindowsButton
            // 
            this.buckWindowsButton.Location = new System.Drawing.Point(686, 393);
            this.buckWindowsButton.Name = "buckWindowsButton";
            this.buckWindowsButton.Size = new System.Drawing.Size(94, 29);
            this.buckWindowsButton.TabIndex = 42;
            this.buckWindowsButton.Text = "戻る";
            this.buckWindowsButton.UseVisualStyleBackColor = true;
            this.buckWindowsButton.Click += new System.EventHandler(this.BuckMenuClick);
            // 
            // adminSearchButton
            // 
            this.adminSearchButton.Location = new System.Drawing.Point(642, 105);
            this.adminSearchButton.Name = "adminSearchButton";
            this.adminSearchButton.Size = new System.Drawing.Size(93, 30);
            this.adminSearchButton.TabIndex = 41;
            this.adminSearchButton.Text = "検索";
            this.adminSearchButton.UseVisualStyleBackColor = true;
            this.adminSearchButton.Click += new System.EventHandler(this.SearchButton);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchTextBox.Location = new System.Drawing.Point(276, 105);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(341, 30);
            this.searchTextBox.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(129, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 30);
            this.label7.TabIndex = 39;
            this.label7.Text = "検索ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "管理者情報変更";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(55, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "パスワード";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(55, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "ユーザー名";
            // 
            // adminPassText
            // 
            this.adminPassText.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adminPassText.Location = new System.Drawing.Point(248, 279);
            this.adminPassText.Name = "adminPassText";
            this.adminPassText.Size = new System.Drawing.Size(409, 30);
            this.adminPassText.TabIndex = 33;
            // 
            // adminNameText
            // 
            this.adminNameText.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adminNameText.Location = new System.Drawing.Point(248, 195);
            this.adminNameText.Name = "adminNameText";
            this.adminNameText.Size = new System.Drawing.Size(409, 30);
            this.adminNameText.TabIndex = 32;
            // 
            // adminChengeButton
            // 
            this.adminChengeButton.Location = new System.Drawing.Point(374, 343);
            this.adminChengeButton.Name = "adminChengeButton";
            this.adminChengeButton.Size = new System.Drawing.Size(93, 29);
            this.adminChengeButton.TabIndex = 29;
            this.adminChengeButton.Text = "変更";
            this.adminChengeButton.UseVisualStyleBackColor = true;
            this.adminChengeButton.Click += new System.EventHandler(this.ChengeButton);
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buckWindowsButton);
            this.Controls.Add(this.adminSearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminPassText);
            this.Controls.Add(this.adminNameText);
            this.Controls.Add(this.adminChengeButton);
            this.Name = "AdminInfo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buckWindowsButton;
        private System.Windows.Forms.Button adminSearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminPassText;
        private System.Windows.Forms.TextBox adminNameText;
        private System.Windows.Forms.Button adminChengeButton;
    }
}