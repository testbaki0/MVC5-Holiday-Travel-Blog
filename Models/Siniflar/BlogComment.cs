﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahatMVC.Models.Siniflar
{
    public class BlogComment
    {
        public  IEnumerable<Blog> Deger1 { get; set; }
        public  IEnumerable<Blog> Deger3 { get; set; }
        public  IEnumerable<Comment> Deger2 { get; set; }
    }
}