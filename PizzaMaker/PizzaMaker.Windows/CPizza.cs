using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    class CPizza
    {
        private int Podstawa; // Cena podstawowa pizzy
        private double Mnoznik; //pizzy
        private int calkowity; //koszt pizzy


        int calkowity();
        public enum ENUMMnoznik
        {
            MALA, DUZA, SREDNIA
        }

        public CPizza()
        {
            this.Podstawa = 15;
            this.Mnoznik = 1;
            calkowity();
        }

        

        public int calkowity(int suma_skladnikow, int podstawa)
        {
            int suma = (int)((suma_skladnikow + podstawa) * Mnoznik);
            return suma;
        }

       
    }
}
