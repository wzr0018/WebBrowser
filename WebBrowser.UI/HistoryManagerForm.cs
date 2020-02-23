using System;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Linq;
using WebBrowser.Data.HistoryDataSetTableAdapters;
using System.Data.SqlClient;
using System.Configuration;
using WebBrowser.Data;
using System.Data;
using System.Web.UI.WebControls;

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wrotoni\Documents\customertestdata\test\Software\Project\M6Project\WebBrowser\WebBrowser.UI\bin\debug\HistoryAndBookmarkDB.mdf;Integrated Security=True");
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            
            var items = HistoryManager.GetItems();
            //historyListBox.Items.Clear();

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

        private void historyDeleteButton_Click(object sender, EventArgs e)
        {
            string itemToBeDeleted = historyListBox.SelectedItem.ToString();

            var items = HistoryManager.GetItems();

            foreach (var item in items)
            {
                if (itemToBeDeleted.Contains(item.URL))
                {
                    string key = item.URL;

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM History WHERE URL LIKE '%" + key + "%'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            historyListBox.Items.RemoveAt(historyListBox.SelectedIndex);
        }


        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE FROM History ";
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
