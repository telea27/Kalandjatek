using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandjatekLea
{
    class Karakter
    {
        private string nev;
        private int szint = 1;
        private int tapasztalat = 0;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public string Nev
        {
            get
            {
                return nev;
            }
            set
            {
                nev = value;
            }
        }
        public int Szint
        {
            get
            {
                return szint;
            }
            set
            {
                szint = value;
            }
        }
        public int Tapasztalat
        {
            get
            {
                return tapasztalat;
            }
            set
            {
                szint = value;
            }
        }
        public int AlapEletero
        {
            get
            {
                return alapEletero;
            }
        }
        public int AlapSebzes
        {
            get
            {
                return alapSebzes;
            }
        }
        public int Eletero
        {
            get
            {
                return eletero;
            }
            set
            {
                eletero = value;
            }
        }
        public int Sebzes
        {
            get
            {
                return alapSebzes + szint;
            }
        }
        public int SzintLepeshez
        {
            get
            {
                return 10 + (szint * 5);
            }
        }
        public int MaxEletero
        {
            get
            {
                return alapEletero + (szint * 3);
            }
        }


        
        public Karakter(string nev, int statuszSablon)
        {
            this.nev = nev;
            if (statuszSablon == 1)
            {
                this.alapEletero = 15;
                this.alapSebzes = 3;
            }
            else if (statuszSablon == 2)
            {
                this.alapEletero = 12;
                this.alapSebzes = 4;
            }
            else if (statuszSablon == 3)
            {
                this.alapEletero = 8;
                this.alapSebzes = 5;
            }
        }
       
    }
}
