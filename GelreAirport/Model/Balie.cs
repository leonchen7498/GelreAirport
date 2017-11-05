using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    public class Balie
    {
        public int Balienummer { get; set; }

        public Balie(int balienummer)
        {
            this.Balienummer = balienummer;
        }

        public override string ToString()
        {
            return "Balie " + this.Balienummer;
        }
    }
}
