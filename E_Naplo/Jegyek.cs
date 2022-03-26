using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Naplo
{
    internal class Jegyek
    {
        public int Sorszám { get; set; }
        public string Név { get; set; }
        public string Évfolyam { get; set; }
        public string Osztály { get; set; }
        public int Osztályzat { get; set; }

        public Jegyek(string line)
        {
            string[] part = line.Split(';');
            Osztályzat = Convert.ToInt32(part[0]);

        }
    }
}
