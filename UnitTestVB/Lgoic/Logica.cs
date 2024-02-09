using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestVB.Lgoic
{
    public  class Logica
    {
        public double BerekenVierkantwortel(int getal)
        {

            return Math.Sqrt(getal);
        
        }

        public double GedeeldDoor(int getal1, int getal2)
        {
            return getal1 / getal2;
        }
    }
}
