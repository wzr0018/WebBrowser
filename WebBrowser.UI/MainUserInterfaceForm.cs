using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MainUserInterfaceForm : Form
    {
        public MainUserInterfaceForm()
        {
            InitializeComponent();
        }

        private void MainUserInterfaceForm_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            String s = toolStripTextBox1.Text;
            
                webBrowser1.Navigate(s);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String show = "";
            show += "Product: CPSC-2713-A01 Web Browser Application";
            show += "\nAuthor: Wilbur Rotoni, Auburn University";
            show += "\nNote: This is my first C# Web Browser Application Project!";
            show += "\nVersion: January - March 2020";

            MessageBox.Show(show);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String s = toolStripTextBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(s);
            }
        }
    }
}
