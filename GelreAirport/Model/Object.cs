using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    public class Object
    {
        public int Volgnummer { get; }

        public int Passagiernummer { get; }

        public int Vluchtnummer { get; }

        public int Gewicht { get; }

        public Object(int volgnummer, int passagiernummer, int vluchtnummer, int gewicht)
        {
            this.Volgnummer = volgnummer;
            this.Passagiernummer = passagiernummer;
            this.Vluchtnummer = vluchtnummer;
            this.Gewicht = gewicht;
        }
    }
}
