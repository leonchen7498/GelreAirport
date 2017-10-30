using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    class Vlucht
    {
        private int vluchtnummer;
        private char gatecode;
        private string maatschappijcode;
        private string luchthavencode;
        private string vliegtuigType;
        private int max_aantal_psgrs;
        private int max_totaalgewicht;
        private int max_ppgewicht;
        private DateTime vertrekTijdstip;
        private DateTime aankomstTijdstip;

        public int Vluchtnummer => vluchtnummer;
        public char Gatecode => gatecode;
        public string Maatschappijcode => maatschappijcode;
        public string Luchthavencode => luchthavencode;
        public string VliegtuigType => vliegtuigType;
        public int MaxAantalPsgrs => max_aantal_psgrs;
        public int MaxTotaalgewicht => max_totaalgewicht;
        public int MaxPpgewicht => max_ppgewicht;
        public DateTime VertrekTijdstip => vertrekTijdstip;
        public DateTime AankomstTijdstip => aankomstTijdstip;

        public Vlucht(int vluchtnummer, char gatecode, string maatschappijcode, string luchthavencode, string vliegtuigType, int maxAantalPsgrs, int maxTotaalgewicht, int maxPpgewicht, DateTime vertrekTijdstip, DateTime aankomstTijdstip)
        {
            this.vluchtnummer = vluchtnummer;
            this.gatecode = gatecode;
            this.maatschappijcode = maatschappijcode;
            this.luchthavencode = luchthavencode;
            this.vliegtuigType = vliegtuigType;
            max_aantal_psgrs = maxAantalPsgrs;
            max_totaalgewicht = maxTotaalgewicht;
            max_ppgewicht = maxPpgewicht;
            this.vertrekTijdstip = vertrekTijdstip;
            this.aankomstTijdstip = aankomstTijdstip;
        }
    }
}
