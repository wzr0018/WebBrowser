using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class EasyNavigation : UserControl
    {
        public EasyNavigation()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void addressBar_Click(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            String s = addressBar.Text;

            webBrowser1.Navigate(s);
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void addressBar_KeyUp(object sender, KeyEventArgs e)
        {
            String s = addressBar.Text;
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(s);
            }
        }
    }
}
