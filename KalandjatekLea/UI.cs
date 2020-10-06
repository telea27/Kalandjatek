using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandjatekLea
{
    class UI
    {
        public void KarakterBekeres()
        {
            Console.WriteLine("Kérem a karakter nevét");
            string BekertNev = Console.ReadLine();
            Console.WriteLine("Kérem a karakter státuszsablonját");
            int BekertStatuszSablon = Convert.ToInt32(Console.ReadLine());
            Karakter k1 = new Karakter(BekertNev, BekertStatuszSablon);
        }
        public void Kiiras()
        {

        }
    }
}
