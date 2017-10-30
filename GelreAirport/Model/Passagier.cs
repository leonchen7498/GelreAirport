using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    class Passagier
    {
        private int nummer;
        private string naam;
        private char geslacht;
        private DateTime geboortedatum;

        public int Nummer
        {
            get => nummer;
        }

        public string Naam
        {
            get => naam;
        }

        public char Geslacht
        {
            get => geslacht;
        }

        public DateTime Geboortedatum
        {
            get => geboortedatum;
        }

        public Passagier(int nummer, string naam, char geslacht, DateTime geboortedatum)
        {
            this.nummer = nummer;
            this.naam = naam;
            this.geslacht = geslacht;
            this.geboortedatum = geboortedatum;
        }
    }
}
