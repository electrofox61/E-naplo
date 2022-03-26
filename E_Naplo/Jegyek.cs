using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Naplo
{
    internal class Jegyek
    {
        public string Név { get; set; }
        public int Matematika { get; set; }
        public int Nyelvtan { get; set; }
        public int Irodalom { get; set; }
        public int Földrajz { get; set; }
        public int Biológia { get; set; }
        public int Kémia { get; set; }
        public int Informatika { get; set; }
        public int Történelem { get; set; }
        public int Szorgalom { get; set; }
        public int Magatartás { get; set; }

        public Jegyek(string line)
        {
            string[] part = line.Split(';');
            Név = part[0];
            Matematika=Convert.ToInt32(part[1]);
            Nyelvtan = Convert.ToInt32(part[2]);
            Irodalom = Convert.ToInt32(part[3]);
            Földrajz = Convert.ToInt32(part[4]);
            Biológia = Convert.ToInt32(part[5]);
            Kémia = Convert.ToInt32(part[6]);
            Informatika = Convert.ToInt32(part[7]);
            Történelem = Convert.ToInt32(part[8]);
            Szorgalom = Convert.ToInt32(part[9]);
            Magatartás = Convert.ToInt32(part[9]);

        }
    }
}
