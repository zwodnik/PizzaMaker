using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    class CPizza
    {
        public int Podstawa = 15; // Cena podstawowa pizzy
        public double Mnoznik; //pizzy
        public int calkowity; //koszt pizzy
        public int SumaSkladnikow = 0;
        
        public enum ENUMMnoznik
        {
            MALA, DUZA, SREDNIA
        }

        public CPizza(ENUMMnoznik enumpizzy)
        {
           

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

            
           // f_calkowity(); //nie ma jeszcze listviev
        }

        

        public void f_calkowity(int podstawa)
        {
            calkowity = (int)((SumaSkladnikow + podstawa) * Mnoznik);
            
        }

        public void ZmianaPizzy(ENUMMnoznik enumpizzy)
        {
            

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

            f_calkowity(Podstawa);
            // f_calkowity(); //nie ma jeszcze listviev
        }

       
    }
}
