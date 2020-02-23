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
using System.Web.UI.WebControls;
using WebBrowser.Data.BookmarksDataSetTableAdapters;
using System.Data.SqlClient;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wrotoni\Documents\customertestdata\test\Software\Project\M6Project\WebBrowser\WebBrowser.UI\bin\debug\HistoryAndBookmarkDB.mdf;Integrated Security=True");
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            listBox1.Items.Clear();

            foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookmarkSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookmarkSearchButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();

            if (bookmarkSearchTextBox.Text.Trim() != "")
            {
                listBox1.Items.Clear();
                foreach (var item in items)

                    if ((item.Title.ToLower().Contains(bookmarkSearchTextBox.Text.Trim().ToLower()) || (item.URL.ToString().ToLower().Contains(bookmarkSearchTextBox.Text.Trim().ToLower()))))
                    {
                        listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                    }
            }

            else
            {
                listBox1.Items.Clear();
                foreach (var item in items)
                {
                    listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }

        private void bookmarkDeleteButton_Click(object sender, EventArgs e)
        {
            string itemToBeDeleted = listBox1.SelectedItem.ToString().ToLower();

            var items = BookmarkManager.GetItems();

            foreach (var item in items)
            {
                if (itemToBeDeleted.Contains(item.URL.ToLower()))
                {
                    string key = item.URL;

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM Bookmarks WHERE URL LIKE '%" + key + "%'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
