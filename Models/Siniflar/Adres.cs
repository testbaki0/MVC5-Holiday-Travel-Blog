using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahatMVC.Models.Siniflar
{
    public class Adres
    {
        public int ID { get; set; }
        public  string Header { get; set; }
        public  string Explanation { get; set; }
        public  string AdresAcik { get; set; }
        public  string Mail { get; set; }
        public  string Phone { get; set; }
        public  string Location { get; set; }
    }
}