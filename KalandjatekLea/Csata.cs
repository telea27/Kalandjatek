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
            listaFeltoltese();

        }

        public void listaFeltoltese()
        {
            StreamReader r = new StreamReader("harcos 1.csv");
            while (!r.EndOfStream)
            {
                string sor = r.ReadLine();
                string[] st = sor.Split(';');
                Karakter h = new Karakter(st[0], Int32.Parse(st[1]));
                ellenfelek.Add(h);
            }
        }

        public void kor()
        {
            Random r = new Random();
            char menu;
            UI interfesz = new UI();
            interfesz.KarakterBekeres();
            Karakter felhasznalo = interfesz.KarakterBekeres();
            int korSzamlalo = 1;

            do
            {
                //---menü
                do
                {

                    interfesz.Menu();
                    menu = interfesz.Menu();
                }
                while (menu != 'a' && menu != 'b' && menu != 'c');
                
                //--- tamadas, Ellenfél választás
                if (menu == 'a')
                {
                    int ellenIndex;
                    do
                    {
                        interfesz.EllenfelKivalasztas();
                        ellenIndex = interfesz.EllenfelKivalasztas();
                    } while (ellenIndex < 1 || ellenIndex > this.ellenfelek.Count);
                    // felhasznalo.Megkuzd(ellenfelek[ellenIndex-1]);
                }
                else if (menu == 'b')
                {
                    //felhasznalo.gyogyul();
                }




                if (korSzamlalo % 3 == 0)
                {
                    int tamadoSorszam = r.Next(0, this.ellenfelek.Count);
                    //this.ellenfelek[tamadoSorszam].Megkuzd(felhasznalo);

                    foreach (Karakter i in ellenfelek)
                    {
                        //i.gyogyul();
                    }
                }
                korSzamlalo++;

            } 
            while (menu != 'c');


        }





    }
}
