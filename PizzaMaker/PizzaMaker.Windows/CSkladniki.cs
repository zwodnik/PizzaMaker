using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    class CSkladniki
    {
        private string Nazwa;
        private Uri UriDuze;
        private Uri UriMale;
        private int Cena;

        public CSkladniki(string nazwa, int cena, Uri uduze, Uri umale)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
            this.UriDuze = uduze;
            this.UriMale = umale;
        }


    }
}
