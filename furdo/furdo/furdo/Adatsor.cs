using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furdo
{
    internal class Adatsor
    {
        
            public int vendegazonosito { get; set; }
            public int furdoreszleg { get; set; }
            public bool kibelepo { get; set; }
            public int ora { get; set; }
            public int perc { get; set; }
            public int masodperc { get; set; }

            public Adatsor(string sor)
            {
                string[] sz = sor.Split(' ');
                this.vendegazonosito = int.Parse(sz[0]);
                this.furdoreszleg = int.Parse(sz[1]);
                if (int.Parse(sz[2]) == 0)
                {
                    kibelepo = true;
                }
                this.ora= int.Parse(sz[3]);
                this.perc = int.Parse(sz[4]);
                this.masodperc = int.Parse(sz[5]);
            }
        
    }
}
