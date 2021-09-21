using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack_s_bakery
{
    class Balk
    {
        //get; set;
        public double Lengte { get; set; }

        public double Breedte { get; set; }

        public double Hoogte { get; set; }

        //Iskubus vergelijking
        public bool Iskubus
        {
            get
            {
                if (Lengte == Breedte && Breedte == Hoogte)
                    return true;
                else
                    return false;
            }
        }

        //Volume van de kubus
        public double Volume
        {
            get
            {
                return (Lengte * Breedte * Hoogte) / 100000;
            }
        }

        //constructor
        public Balk(double lengte, double breedte, double hoogte)
        {
            if (lengte > 0 && lengte < 100 && breedte > 0 && breedte < 100 && hoogte > 0 && hoogte < 100)
            {
                Lengte = lengte;
                Breedte = breedte;
                Hoogte = hoogte;
            }
            else
                throw new ArgumentException("Maatvoering moet groter zijn als 0 en kleiner dan 100");

        }
    }
}
