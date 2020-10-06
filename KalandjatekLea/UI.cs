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
            Karakter karakter = new Karakter(BekertNev, BekertStatuszSablon);
        }
        public void Kiiras()
        {

        }
        public int EllenfelKivalasztas()
        {
            Console.WriteLine("A lista hanyadik harcosával szeretne megküzdeni?");
            Console.WriteLine("Hanyadik harcossal szeretne küzdeni?");
            int szam = Convert.ToInt32(Console.ReadLine());
            return szam;
        }
        
        public char Menu()
        {
            char k;
            Console.WriteLine("Mit kíván tenni a harcossal?\na) Megküzdeni\tb) Gyógyulni\tc)Kilépni");
            k = Convert.ToChar(Console.ReadLine());
            return k;
        }
    }
}
