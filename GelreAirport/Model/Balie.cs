using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    class Balie
    {
        private int balienummer;

        public int Balienummer
        {
            get { return balienummer; }
        }

        public Balie(int balienummer)
        {
            this.balienummer = balienummer;
        }
    }
}
