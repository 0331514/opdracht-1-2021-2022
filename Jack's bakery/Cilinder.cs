using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack_s_bakery
{
    class Cilinder
    {
        public double Breedte { get; set; }

        public double Hoogte { get; set; }

        public Cilinder(double breedte, double hoogte)
        {
            if(breedte > 0 && breedte < 100 && hoogte > 0 && hoogte < 100)
            {
                Breedte = breedte;
                Hoogte = hoogte;
            }
            else
                throw new ArgumentException("Maatvoering moet groter zijn als 0 en kleiner dan 100");
        }

        public double VolumeCilinder
        {
           
            get
            {
                double straal = Breedte / 2;
                return (Math.Pow(straal, 2) * Hoogte);
            }
        }


    }

}
