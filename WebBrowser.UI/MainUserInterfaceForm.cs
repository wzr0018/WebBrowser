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
            EasyNavigation easy = new EasyNavigation();
            easy.Dock = DockStyle.Fill;
           
            TabPage newTab = new TabPage("New Tab");
            newTab.Controls.Add(easy);
            tabControl1.TabPages.Add(newTab);
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean clicked = true;
            var easy = new EasyNavigation(clicked);
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
           
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void easyNavigation1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.T))
            {
                EasyNavigation easy = new EasyNavigation();
                easy.Dock = DockStyle.Fill;

                TabPage newTab = new TabPage("New Tab");
                newTab.Controls.Add(easy);
                tabControl1.TabPages.Add(newTab);
            }

            if (e.Control && (e.KeyCode == Keys.W))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            Boolean clicked = true;
            var easy = new EasyNavigation(clicked);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm bmf = new BookmarkManagerForm();
            bmf.ShowDialog();
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagerForm hmf = new HistoryManagerForm();
            hmf.ShowDialog();

        }
    }
}
