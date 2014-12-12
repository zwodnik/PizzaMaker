using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    class CSkladniki
    {
        public string Nazwa
        {
            set;
            get;
        }
        public Uri UriDuze
        {
            set;
            get;
        }
        public Uri UriMale
        {
            set;
            get;
        }
        public int Cena
        {
            set;
            get;
        }

        /*public CSkladniki(string nazwa, int cena, Uri uduze, Uri umale)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
            this.UriDuze = uduze;
            this.UriMale = umale;
        }*/

        public CSkladniki() { }



    }
}
