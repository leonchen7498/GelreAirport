using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    public class Passagier
    {
        public int Nummer { get; }

        public string Naam { get; }

        public char Geslacht { get; }

        public DateTime Geboortedatum { get; }

        public Passagier(int nummer, string naam, char geslacht, DateTime geboortedatum)
        {
            this.Nummer = nummer;
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.Geboortedatum = geboortedatum;
        }
    }
}
