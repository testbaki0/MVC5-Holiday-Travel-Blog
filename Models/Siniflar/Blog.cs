using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahatMVC.Models.Siniflar
{
    public class Blog
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}