
namespace Form_Develop {
    partial class UsersTable {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.buckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // dataSearch
            // 
            this.dataSearch.Location = new System.Drawing.Point(26, 112);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.Size = new System.Drawing.Size(104, 62);
            this.dataSearch.TabIndex = 20;
            this.dataSearch.Text = "テーブル表示";
            this.dataSearch.UseVisualStyleBackColor = true;
            this.dataSearch.Click += new System.EventHandler(this.DataSearchClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(253, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(521, 368);
            this.dataGridView2.TabIndex = 19;
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(147, 63);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(100, 22);
            this.deleteTextBox.TabIndex = 18;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(26, 28);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 66);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "データ削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // buckButton
            // 
            this.buckButton.Location = new System.Drawing.Point(26, 380);
            this.buckButton.Name = "buckButton";
            this.buckButton.Size = new System.Drawing.Size(104, 43);
            this.buckButton.TabIndex = 16;
            this.buckButton.Text = "戻る";
            this.buckButton.UseVisualStyleBackColor = true;
            this.buckButton.Click += new System.EventHandler(this.BuckMenu);
            // 
            // UsersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.buckButton);
            this.Name = "UsersTable";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dataSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button buckButton;
    }
}