﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
    }
}
