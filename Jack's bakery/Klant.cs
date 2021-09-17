using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack_s_bakery
{
    class Klant
    { 
        public string voornaam { get; set; }
        public string tussenvoegsel { get; set; }
        public string achternaam { get; set; }
        public string adres { get; set; }
        public string woonplaats { get; set; }
        public string postcode { get; set; }

        public Klant(string voornaam, string tussenvoegsel, string achternaam, string adres, string woonplaats, string postcode)
        {
            this.voornaam = voornaam;
            this.tussenvoegsel = tussenvoegsel;
            this.achternaam = achternaam;
            this.adres = adres;
            this.woonplaats = woonplaats;
            this.postcode = postcode;
        }
    }
}
