
namespace Form_Develop {
    partial class Table {
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
            this.buckButton = new System.Windows.Forms.Button();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataSearch = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buckButton
            // 
            this.buckButton.Location = new System.Drawing.Point(12, 395);
            this.buckButton.Name = "buckButton";
            this.buckButton.Size = new System.Drawing.Size(104, 43);
            this.buckButton.TabIndex = 6;
            this.buckButton.Text = "戻る";
            this.buckButton.UseVisualStyleBackColor = true;
            this.buckButton.Click += new System.EventHandler(this.BackDisplay);
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(133, 78);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(100, 22);
            this.deleteTextBox.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(239, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(521, 368);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataSearch
            // 
            this.dataSearch.Location = new System.Drawing.Point(12, 127);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.Size = new System.Drawing.Size(104, 62);
            this.dataSearch.TabIndex = 11;
            this.dataSearch.Text = "テーブル表示";
            this.dataSearch.UseVisualStyleBackColor = true;
            this.dataSearch.Click += new System.EventHandler(this.DataSearch_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 43);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 66);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "データ削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteData);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // Table
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
            this.Name = "Table";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buckButton;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button dataSearch;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
    }
}