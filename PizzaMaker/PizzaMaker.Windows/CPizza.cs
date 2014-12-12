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


        
        public enum ENUMMnoznik
        {
            MALA, DUZA, SREDNIA
        }

        public CPizza(ENUMMnoznik enumpizzy)
        {
            this.Podstawa = 15;
            
               
            this.Podstawa = 15;

            if (enumpizzy == ENUMMnoznik.MALA)
            {
                this.Mnoznik = 1;
            }
            if (enumpizzy == ENUMMnoznik.SREDNIA)
            {
                this.Mnoznik = 1.2;
            }
            if (enumpizzy == ENUMMnoznik.DUZA)
            {
                this.Mnoznik = 1.4;
            }

            //this.Mnoznik = 1;
            //calkowity(); //nie ma jeszcze listviev
        }

        

        private int calkowity(int suma_skladnikow, int podstawa)
        {
            int suma = (int)((suma_skladnikow + podstawa) * Mnoznik);
            return suma;
        }

       
    }
}
