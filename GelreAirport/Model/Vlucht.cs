using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelreAirport.Model
{
    public class Vlucht
    {
        public int Vluchtnummer { get; }

        public char Gatecode { get; }

        public string Maatschappijcode { get; }

        public string Luchthavencode { get; }

        public string VliegtuigType { get; }

        public int MaxAantalPsgrs { get; }

        public int MaxTotaalgewicht { get; }

        public int MaxPpgewicht { get; }

        public DateTime VertrekTijdstip { get; }

        public DateTime AankomstTijdstip { get; }

        public Vlucht(int vluchtnummer, char gatecode, string maatschappijcode, string luchthavencode, string vliegtuigType, int maxAantalPsgrs, int maxTotaalgewicht, int maxPpgewicht, DateTime vertrekTijdstip, DateTime aankomstTijdstip)
        {
            this.Vluchtnummer = vluchtnummer;
            this.Gatecode = gatecode;
            this.Maatschappijcode = maatschappijcode;
            this.Luchthavencode = luchthavencode;
            this.VliegtuigType = vliegtuigType;
            MaxAantalPsgrs = maxAantalPsgrs;
            MaxTotaalgewicht = maxTotaalgewicht;
            MaxPpgewicht = maxPpgewicht;
            this.VertrekTijdstip = vertrekTijdstip;
            this.AankomstTijdstip = aankomstTijdstip;
        }
    }
}
