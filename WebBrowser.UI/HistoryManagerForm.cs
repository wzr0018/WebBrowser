using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using WebBrowser.UI;

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyListBox.Items.Clear();

                historyListBox.Items.Clear();
                foreach (var item in items)
                {       
                    historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }          
        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void historySearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void historySearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyListBox.Items.Clear();

            if (historySearchTextBox.Text.Trim() != "")
            {
                historyListBox.Items.Clear();
                foreach (var item in items)

                    if ((item.Title.Contains(historySearchTextBox.Text.Trim()) || (item.URL.ToString().Contains(historySearchTextBox.Text.Trim()))))
                    {
                        historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                    }
            }

            else
            {
                historyListBox.Items.Clear();
                foreach (var item in items)
                {
                    historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }
    }
}
