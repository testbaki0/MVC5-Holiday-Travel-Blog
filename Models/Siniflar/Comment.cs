using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahatMVC.Models.Siniflar
{
    public class Comment
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Coment { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}