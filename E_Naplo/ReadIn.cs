using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Naplo
{
    internal class ReadIn
    {
        public int Sorszám { get; set; }
        public string Név { get; set; }
        public string Évfolyam { get; set; }
        public string Osztály { get; set; }
        public ReadIn(string line)
        {
            string[] part = line.Split(';','/');
            Sorszám = Convert.ToInt32(part[0]);
            Név = part[1];
            Évfolyam = part[2];
            Osztály = part[3];
        }
    }
}
