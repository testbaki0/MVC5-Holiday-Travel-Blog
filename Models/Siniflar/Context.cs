using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TatilSeyahatMVC.Models.Siniflar
{
    public class Context :DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Adres> Adress { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}