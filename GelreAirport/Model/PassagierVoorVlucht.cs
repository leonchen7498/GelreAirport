using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    public class PassagierVoorVlucht
    {
        public int Passagiernummer { get; }

        public int Vluchtnummer { get; }

        public Balie Balienummer { get; }

        public DateTime Inchecktijdstip { get; }

        public string Stoel { get; }

        public PassagierVoorVlucht(int passagiernummer, int vluchtnummer, Balie balienummer, DateTime inchecktijdstip, string stoel)
        {
            this.Passagiernummer = passagiernummer;
            this.Vluchtnummer = vluchtnummer;
            this.Balienummer = balienummer;
            this.Inchecktijdstip = inchecktijdstip;
            this.Stoel = stoel;
        }
    }
}
