using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KalandjatekLea
{
    class Csata
    {
        private List<Karakter> ellenfelek;

        public Csata(List<Karakter> ellenfelek)
        {
            this.ellenfelek = ellenfelek;
            listaFeltoltese();
        }

        public void listaFeltoltese()
        {
            StreamReader r = new StreamReader("harcos 1.csv");
            while (!r.EndOfStream)
            {
                string sor = r.ReadLine();
                string[] st = sor.Split(';');
                Karakter h = new Karakter(st[0],Int32.Parse(st[1]));
                ellenfelek.Add(h);
            }
        }

        public void kor(Karakter felhasznalo)
        {
            UI interfesz = new UI();
            do
            {
                UI.KarakterBekeres();

                //
                felhasznalo.Megkuzd();



            } while ();
        }





    }
}
