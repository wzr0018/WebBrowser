using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

// adding codes per project instructions:



// end

namespace WebBrowser.UI
{

    // adding code per project instruction:
    
        //end
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
            String s = addressBar.Text;

            webBrowser1.Navigate(s);
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

        private void facebookButton_Click(object sender, EventArgs e)
        {
            String s = "www.facebook.com";
            webBrowser1.Navigate(s);

        }

        private void amazonButton_Click(object sender, EventArgs e)
        {
            String s = "www.amazon.com";

            webBrowser1.Navigate(s);
        }

        private void googleButton_Click(object sender, EventArgs e)
        {
            String s = "www.google.com";

            webBrowser1.Navigate(s);

        }

        private void gmailButton_Click(object sender, EventArgs e)
        {
            String s = "www.gmail.com";
            webBrowser1.Navigate(s);

        }

        private void yahooButton_Click(object sender, EventArgs e)
        {
            String s = "www.yahoo.com";

            webBrowser1.Navigate(s);
        }

        private void cnnButton_Click(object sender, EventArgs e)
        {
            String s = "www.cnn.com";

            webBrowser1.Navigate(s);
        }

        private void espnButton_Click(object sender, EventArgs e)
        {
            String s = "www.espn.com";

            webBrowser1.Navigate(s);
        }

        private void bingButton_Click(object sender, EventArgs e)
        {
            String s = "www.bing.com";

            webBrowser1.Navigate(s);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressBar.Text = webBrowser1.Url.AbsoluteUri;
        }
    }
}
