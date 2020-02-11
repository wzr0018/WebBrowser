using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarkDataSetTableAdapters;
namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddItem(BookmarkItem Item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(Item.URL, Item.Title);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;

                results.Add(item);
            }

            return results;
        }
    }
}
