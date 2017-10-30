using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    class Object
    {
        private int volgnummer;
        private int passagiernummer;
        private int vluchtnummer;
        private int gewicht;

        public int Volgnummer
        {
            get { return volgnummer; }
        }

        public int Passagiernummer
        {
            get { return passagiernummer; }
        }

        public int Vluchtnummer
        {
            get { return vluchtnummer; }
        }

        public int Gewicht
        {
            get { return gewicht; }
        }

        public Object(int volgnummer, int passagiernummer, int vluchtnummer, int gewicht)
        {
            this.volgnummer = volgnummer;
            this.passagiernummer = passagiernummer;
            this.vluchtnummer = vluchtnummer;
            this.gewicht = gewicht;
        }
    }
}
