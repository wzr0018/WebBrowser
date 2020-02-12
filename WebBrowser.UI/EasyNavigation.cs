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
            try
            {
                forwardLinks.Push(addressBar.Text);

                string pop = backLinks.Pop();
                webBrowser1.Navigate(pop);
            }
            catch (InvalidOperationException) { }
            catch(NullReferenceException) { }
            
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

            try
            {
                backLinks.Push(addressBar.Text);

                string pop = forwardLinks.Pop();
                webBrowser1.Navigate(pop);
            }
            catch (InvalidOperationException) { }
            catch (NullReferenceException) { }
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

            BookmarkManager.AddItem(bookmarkItem);

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

            WebBrowser.Logic.HistoryManager.AddItem(historyItem);


        }

        // get website title page

        public string GetPageTitle()
        {
            string link = webBrowser1.Url.AbsoluteUri;
            try
            {
                WebClient wc = new WebClient();
                string html = wc.DownloadString(link);

                Regex x = new Regex("<title>(.*)</title>");
                MatchCollection m = x.Matches(html);

                if (m.Count > 0)
                {
                    return m[0].Value.Replace("<title>", "").Replace("</title>", "");
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not connect. Error:" + ex.Message);
                return "";
            }
        }

        private void EasyNavigation_Load(object sender, EventArgs e)
        {

        }
        //end

    }
}
