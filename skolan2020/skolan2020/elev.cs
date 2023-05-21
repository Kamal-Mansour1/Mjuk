using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skolan2020
{
    public class elev
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public double Längd { get; set; }
        public double Vikt { get; set; }
        public DateTime Födelsedatum { get; set; }

        public elev(string förnamn, string efternamn, double längd, double vikt, DateTime födelsedatum)
        {
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
            this.Längd = längd;
            this.Vikt = vikt;
            this.Födelsedatum = födelsedatum;
        }

        public string helanamnet()
        {
            return 
                Förnamn + " " + Efternamn;
        }
        public double BeräknaBMI()
        {
            return Vikt / (Längd * Längd);
        }
        public bool Ärmyndig()
        {
            if (Födelsedatum.AddYears(18) <= DateTime.Today)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
