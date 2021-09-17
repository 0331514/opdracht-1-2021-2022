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
            if(breedte > 0 && hoogte > 0)
            {
                Breedte = breedte;
                Hoogte = hoogte;
            }
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
