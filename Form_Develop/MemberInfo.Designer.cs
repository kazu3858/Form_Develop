
namespace Form_Develop {
    partial class MemberInfo {
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
            this.chengeButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.buckWindowsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminChengeButton
            // 
            this.chengeButton.Location = new System.Drawing.Point(363, 391);
            this.chengeButton.Name = "adminChengeButton";
            this.chengeButton.Size = new System.Drawing.Size(93, 29);
            this.chengeButton.TabIndex = 13;
            this.chengeButton.Text = "変更";
            this.chengeButton.UseVisualStyleBackColor = true;
            this.chengeButton.Click += new System.EventHandler(this.InfoChange);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.firstNameBox.Location = new System.Drawing.Point(226, 201);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(159, 30);
            this.firstNameBox.TabIndex = 14;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lastNameBox.Location = new System.Drawing.Point(476, 204);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(159, 30);
            this.lastNameBox.TabIndex = 15;
            // 
            // adminNameText
            // 
            this.addressBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addressBox.Location = new System.Drawing.Point(226, 257);
            this.addressBox.Name = "adminNameText";
            this.addressBox.Size = new System.Drawing.Size(409, 30);
            this.addressBox.TabIndex = 16;
            // 
            // adminPassText
            // 
            this.numberTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numberTextBox.Location = new System.Drawing.Point(226, 315);
            this.numberTextBox.Name = "adminPassText";
            this.numberTextBox.Size = new System.Drawing.Size(409, 30);
            this.numberTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(177, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "氏";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(427, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(47, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "メールアドレス";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(87, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "電話番号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "会員情報";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(121, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "検索ID";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchTextBox.Location = new System.Drawing.Point(268, 103);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(341, 30);
            this.searchTextBox.TabIndex = 26;
            // 
            // adminSearchButton
            // 
            this.memberSearchButton.Location = new System.Drawing.Point(634, 103);
            this.memberSearchButton.Name = "adminSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(93, 30);
            this.memberSearchButton.TabIndex = 27;
            this.memberSearchButton.Text = "検索";
            this.memberSearchButton.UseVisualStyleBackColor = true;
            this.memberSearchButton.Click += new System.EventHandler(this.SearchData);
            // 
            // buckWindowsButton
            // 
            this.buckWindowsButton.Location = new System.Drawing.Point(678, 391);
            this.buckWindowsButton.Name = "buckWindowsButton";
            this.buckWindowsButton.Size = new System.Drawing.Size(94, 29);
            this.buckWindowsButton.TabIndex = 28;
            this.buckWindowsButton.Text = "戻る";
            this.buckWindowsButton.UseVisualStyleBackColor = true;
            this.buckWindowsButton.Click += new System.EventHandler(this.BuckButton);
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buckWindowsButton);
            this.Controls.Add(this.memberSearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.chengeButton);
            this.Name = "MemberInfo";
            this.Text = "Form1";           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chengeButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.Button buckWindowsButton;
    }
}