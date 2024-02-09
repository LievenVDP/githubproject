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

        public double Berekengemiddelde(double getal1, double getal2)
        {
            return (getal1 + getal2) / 2;

        }
    }
}
