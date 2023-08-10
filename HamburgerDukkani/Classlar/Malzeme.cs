using HamburgerDukkani.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HamburgerDukkani.Classlar
{
    public class Malzeme:IUrun
    {
        public string UrunAdi { get; set; }

        public int Fiyat { get; set; }
    }
}
