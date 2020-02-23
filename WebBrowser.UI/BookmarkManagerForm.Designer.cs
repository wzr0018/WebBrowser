namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bookmarkDeleteButton = new System.Windows.Forms.Button();
            this.bookmarkSearchButton = new System.Windows.Forms.Button();
            this.bookmarkSearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 404);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bookmarkDeleteButton
            // 
            this.bookmarkDeleteButton.Location = new System.Drawing.Point(421, 4);
            this.bookmarkDeleteButton.Name = "bookmarkDeleteButton";
            this.bookmarkDeleteButton.Size = new System.Drawing.Size(122, 36);
            this.bookmarkDeleteButton.TabIndex = 6;
            this.bookmarkDeleteButton.Text = "Delete";
            this.bookmarkDeleteButton.UseVisualStyleBackColor = true;
            this.bookmarkDeleteButton.Click += new System.EventHandler(this.bookmarkDeleteButton_Click);
            // 
            // bookmarkSearchButton
            // 
            this.bookmarkSearchButton.Location = new System.Drawing.Point(293, 4);
            this.bookmarkSearchButton.Name = "bookmarkSearchButton";
            this.bookmarkSearchButton.Size = new System.Drawing.Size(122, 36);
            this.bookmarkSearchButton.TabIndex = 5;
            this.bookmarkSearchButton.Text = "Search";
            this.bookmarkSearchButton.UseVisualStyleBackColor = true;
            this.bookmarkSearchButton.Click += new System.EventHandler(this.bookmarkSearchButton_Click);
            // 
            // bookmarkSearchTextBox
            // 
            this.bookmarkSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmarkSearchTextBox.Location = new System.Drawing.Point(7, 4);
            this.bookmarkSearchTextBox.Multiline = true;
            this.bookmarkSearchTextBox.Name = "bookmarkSearchTextBox";
            this.bookmarkSearchTextBox.Size = new System.Drawing.Size(270, 36);
            this.bookmarkSearchTextBox.TabIndex = 4;
            this.bookmarkSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookmarkSearchTextBox.TextChanged += new System.EventHandler(this.bookmarkSearchTextBox_TextChanged);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkDeleteButton);
            this.Controls.Add(this.bookmarkSearchButton);
            this.Controls.Add(this.bookmarkSearchTextBox);
            this.Controls.Add(this.listBox1);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bookmarkDeleteButton;
        private System.Windows.Forms.Button bookmarkSearchButton;
        public System.Windows.Forms.TextBox bookmarkSearchTextBox;
    }
}