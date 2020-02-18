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
using System.Net;
using System.Text.RegularExpressions;
using WebBrowser.Logic;
using WebBrowser.UI;



namespace WebBrowser.UI
{

    public partial class EasyNavigation : UserControl
    {
        // adding code per project instruction:
        Stack<string> forwardLinks = new Stack<string>();
        Stack<string> backLinks = new Stack<string>();
        List<String> bm = new List<String>();


        public EasyNavigation()
        {
            InitializeComponent();
        }

        public EasyNavigation(Boolean clicked)
        {
            if (clicked == true)
            {
                forwardLinks.Clear();
                backLinks.Clear();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

            /* try
             {
                 forwardLinks.Push(addressBar.Text);

                 string pop = backLinks.Pop();
                 webBrowser1.Navigate(pop);
             }
             catch (InvalidOperationException) { }
             catch(NullReferenceException) { }*/

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

            /*  try
             {
                 backLinks.Push(addressBar.Text);

                 string pop = forwardLinks.Pop();
                 webBrowser1.Navigate(pop);
             }
             catch (InvalidOperationException) { }
             catch (NullReferenceException) { } */
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
            var item = new BookmarkManager();

            string pageTitle = GetPageTitle();
            string url = webBrowser1.Url.AbsoluteUri;

            var bookmarkItem = new BookmarkItem();
            bookmarkItem.URL = url;
            bookmarkItem.Title = pageTitle;

            if (bm.Contains(url) == true)
            {
                MessageBox.Show("This page is already in your bookmark");
            }
            else
            {
                bm.Add(url);
                BookmarkManager.AddItem(bookmarkItem);
            }
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

            backLinks.Push(addressBar.Text);

            string pageTitle = GetPageTitle();
            string url = webBrowser1.Url.AbsoluteUri;

            var historyItem = new HistoryItem();
            historyItem.Date = DateTime.Now;
            historyItem.Title = pageTitle;
            historyItem.URL = url;

            HistoryManager.AddItem(historyItem);

            
        }

        // get website title page

        public string GetPageTitle()
        {
            Uri myUri = new Uri(webBrowser1.Url.AbsoluteUri);
            string host = myUri.Host;

            return host;
        }

        private void EasyNavigation_Load(object sender, EventArgs e)
        {

        }

        public void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
   
                if ((int)e.CurrentProgress > 0)
                {
                    toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
                    toolStripProgressBar1.Value = (int)e.CurrentProgress;
                }     

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        //end

    }
}

