namespace WebBrowser.UI
{
    partial class EasyNavigation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyNavigation));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.addressBar = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.espnButton = new System.Windows.Forms.ToolStripButton();
            this.cnnButton = new System.Windows.Forms.ToolStripButton();
            this.yahooButton = new System.Windows.Forms.ToolStripButton();
            this.gmailButton = new System.Windows.Forms.ToolStripButton();
            this.googleButton = new System.Windows.Forms.ToolStripButton();
            this.amazonButton = new System.Windows.Forms.ToolStripButton();
            this.facebookButton = new System.Windows.Forms.ToolStripButton();
            this.bingButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.refreshButton,
            this.homeButton,
            this.addressBar,
            this.goButton,
            this.bookmarkButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1364, 47);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 44);
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(44, 44);
            this.forwardButton.Text = "Forward";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(44, 44);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(44, 44);
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // addressBar
            // 
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(600, 47);
            this.addressBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyUp);
            this.addressBar.Click += new System.EventHandler(this.addressBar_Click);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(44, 44);
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
            this.bookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(44, 44);
            this.bookmarkButton.Text = "Bookmark";
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 71);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1345, 522);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookButton,
            this.amazonButton,
            this.googleButton,
            this.gmailButton,
            this.yahooButton,
            this.cnnButton,
            this.espnButton,
            this.bingButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 32);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(245, 27);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // espnButton
            // 
            this.espnButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.espnButton.Image = ((System.Drawing.Image)(resources.GetObject("espnButton.Image")));
            this.espnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.espnButton.Name = "espnButton";
            this.espnButton.Size = new System.Drawing.Size(29, 24);
            this.espnButton.Text = "toolStripButton7";
            this.espnButton.Click += new System.EventHandler(this.espnButton_Click);
            // 
            // cnnButton
            // 
            this.cnnButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cnnButton.Image = ((System.Drawing.Image)(resources.GetObject("cnnButton.Image")));
            this.cnnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cnnButton.Name = "cnnButton";
            this.cnnButton.Size = new System.Drawing.Size(29, 24);
            this.cnnButton.Text = "toolStripButton6";
            this.cnnButton.Click += new System.EventHandler(this.cnnButton_Click);
            // 
            // yahooButton
            // 
            this.yahooButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yahooButton.Image = ((System.Drawing.Image)(resources.GetObject("yahooButton.Image")));
            this.yahooButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yahooButton.Name = "yahooButton";
            this.yahooButton.Size = new System.Drawing.Size(29, 24);
            this.yahooButton.Text = "toolStripButton5";
            this.yahooButton.Click += new System.EventHandler(this.yahooButton_Click);
            // 
            // gmailButton
            // 
            this.gmailButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gmailButton.Image = ((System.Drawing.Image)(resources.GetObject("gmailButton.Image")));
            this.gmailButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gmailButton.Name = "gmailButton";
            this.gmailButton.Size = new System.Drawing.Size(29, 24);
            this.gmailButton.Text = "toolStripButton3";
            this.gmailButton.Click += new System.EventHandler(this.gmailButton_Click);
            // 
            // googleButton
            // 
            this.googleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.googleButton.Image = ((System.Drawing.Image)(resources.GetObject("googleButton.Image")));
            this.googleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.googleButton.Name = "googleButton";
            this.googleButton.Size = new System.Drawing.Size(29, 24);
            this.googleButton.Text = "toolStripButton2";
            this.googleButton.Click += new System.EventHandler(this.googleButton_Click);
            // 
            // amazonButton
            // 
            this.amazonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.amazonButton.Image = ((System.Drawing.Image)(resources.GetObject("amazonButton.Image")));
            this.amazonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.amazonButton.Name = "amazonButton";
            this.amazonButton.Size = new System.Drawing.Size(29, 24);
            this.amazonButton.Text = "toolStripButton4";
            this.amazonButton.Click += new System.EventHandler(this.amazonButton_Click);
            // 
            // facebookButton
            // 
            this.facebookButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facebookButton.Image = ((System.Drawing.Image)(resources.GetObject("facebookButton.Image")));
            this.facebookButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.facebookButton.Name = "facebookButton";
            this.facebookButton.Size = new System.Drawing.Size(29, 24);
            this.facebookButton.Text = "toolStripButton1";
            this.facebookButton.Click += new System.EventHandler(this.facebookButton_Click);
            // 
            // bingButton
            // 
            this.bingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bingButton.Image = ((System.Drawing.Image)(resources.GetObject("bingButton.Image")));
            this.bingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bingButton.Name = "bingButton";
            this.bingButton.Size = new System.Drawing.Size(29, 29);
            this.bingButton.Text = "toolStripButton1";
            this.bingButton.Click += new System.EventHandler(this.bingButton_Click);
            // 
            // EasyNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EasyNavigation";
            this.Size = new System.Drawing.Size(1364, 661);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton homeButton;
        private System.Windows.Forms.ToolStripTextBox addressBar;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.ToolStripButton bookmarkButton;
        public System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton facebookButton;
        private System.Windows.Forms.ToolStripButton amazonButton;
        private System.Windows.Forms.ToolStripButton googleButton;
        private System.Windows.Forms.ToolStripButton gmailButton;
        private System.Windows.Forms.ToolStripButton yahooButton;
        private System.Windows.Forms.ToolStripButton cnnButton;
        private System.Windows.Forms.ToolStripButton espnButton;
        private System.Windows.Forms.ToolStripButton bingButton;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.WebBrowser webBrowser1;
    }
}
