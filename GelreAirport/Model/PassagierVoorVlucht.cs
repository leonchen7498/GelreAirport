using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    class PassagierVoorVlucht
    {
        private int passagiernummer;
        private int vluchtnummer;
        private int balienummer;
        private DateTime inchecktijdstip;
        private string stoel;

        public int Passagiernummer
        {
            get { return passagiernummer; }
        }

        public int Vluchtnummer
        {
            get { return vluchtnummer; }
        }

        public int Balienummer
        {
            get { return balienummer; }
        }

        public DateTime Inchecktijdstip
        {
            get { return inchecktijdstip; }
        }

        public string Stoel
        {
            get { return stoel; }
        }

        public PassagierVoorVlucht(int passagiernummer, int vluchtnummer, int balienummer, DateTime inchecktijdstip, string stoel)
        {
            this.passagiernummer = passagiernummer;
            this.vluchtnummer = vluchtnummer;
            this.balienummer = balienummer;
            this.inchecktijdstip = inchecktijdstip;
            this.stoel = stoel;
        }
    }
}
