using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furdo
{
    
     class Program
    {
        static void Main(string[] args)
        {
            string[] fajl = File.ReadAllLines("furdoadat.txt",Encoding.UTF8);
            List<Adatsor> listaFurdo = new List<Adatsor>();
            foreach (var item in fajl)
            {
                listaFurdo.Add(new Adatsor(item));
            }

            var feladat2 = listaFurdo.Where(x => x.kibelepo == false && x.furdoreszleg == 0).ToList();

            Console.WriteLine($"2. feladat: Az első vendég{feladat2[0].ora}:{feladat2}:{feladat2}");
        }
    }
}
