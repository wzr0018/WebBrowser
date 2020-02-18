namespace WebBrowser.UI
{
    partial class HistoryManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.historySearchTextBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.Button();
            this.historyDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 16;
            this.historyListBox.Location = new System.Drawing.Point(1, 54);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(714, 500);
            this.historyListBox.TabIndex = 0;
            this.historyListBox.SelectedIndexChanged += new System.EventHandler(this.historyListBox_SelectedIndexChanged);
            // 
            // historySearchTextBox
            // 
            this.historySearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historySearchTextBox.Location = new System.Drawing.Point(12, 12);
            this.historySearchTextBox.Multiline = true;
            this.historySearchTextBox.Name = "historySearchTextBox";
            this.historySearchTextBox.Size = new System.Drawing.Size(365, 36);
            this.historySearchTextBox.TabIndex = 1;
            this.historySearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.historySearchTextBox.TextChanged += new System.EventHandler(this.historySearchTextBox_TextChanged);
            // 
            // historySearchButton
            // 
            this.historySearchButton.Location = new System.Drawing.Point(398, 12);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(122, 36);
            this.historySearchButton.TabIndex = 2;
            this.historySearchButton.Text = "Search";
            this.historySearchButton.UseVisualStyleBackColor = true;
            this.historySearchButton.Click += new System.EventHandler(this.historySearchButton_Click);
            // 
            // historyDeleteButton
            // 
            this.historyDeleteButton.Location = new System.Drawing.Point(543, 12);
            this.historyDeleteButton.Name = "historyDeleteButton";
            this.historyDeleteButton.Size = new System.Drawing.Size(122, 36);
            this.historyDeleteButton.TabIndex = 3;
            this.historyDeleteButton.Text = "Delete";
            this.historyDeleteButton.UseVisualStyleBackColor = true;
            this.historyDeleteButton.Click += new System.EventHandler(this.historyDeleteButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 553);
            this.Controls.Add(this.historyDeleteButton);
            this.Controls.Add(this.historySearchButton);
            this.Controls.Add(this.historySearchTextBox);
            this.Controls.Add(this.historyListBox);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        public System.Windows.Forms.TextBox historySearchTextBox;
        private System.Windows.Forms.Button historySearchButton;
        private System.Windows.Forms.Button historyDeleteButton;
    }
}