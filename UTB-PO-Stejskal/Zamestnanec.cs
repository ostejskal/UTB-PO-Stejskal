using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    public class Zamestnanec
    {
        private String Jmeno;
        public String jmeno
        {
            get { return Jmeno; } 
            set { Jmeno = value; } 
        }
        String Prijmeni;
        public String prijmeni
        {
            get { return Prijmeni; }
            set { Prijmeni = value; }
        }
        String PracovniEmail;
        public String pracovniemail
        {
            get { return PracovniEmail; }
            set { PracovniEmail = value; }
        }
        String SoukromyEmail;
        public String soukromyemail
        {
            get { return SoukromyEmail; }
            set { SoukromyEmail = value; }
        }
        bool Doktorand;
        public bool doktorand
        {
            get { return Doktorand; }
            set { Doktorand = value; }
        }
        double Uvazek;
        public double uvazek
        {
            get { return Uvazek; }
            set { Uvazek = value; }
        }
        public List<PracovniStitek> SeznamStitku;
        String PracovniTelefon;
        String SoukromyTelefon;
        public String pracovnitelefon
        {
            get { return PracovniTelefon; }
            set { PracovniTelefon = value; }
        }
        public String soukromytelefon
        {
            get { return SoukromyTelefon; }
            set { SoukromyTelefon = value; }
        }

        public double PracovniBody { get; set; }
        public double PracovniBodycalc (TypPracStitek typstitek, Jazyk jazyk)
        {
            if (jazyk==Jazyk.cz && typstitek==TypPracStitek.prednaska)
            {
                return 1.8;
            }
            else if (jazyk == Jazyk.eng && typstitek == TypPracStitek.prednaska)
            {
                return 2.4;
            }
            else if (jazyk == Jazyk.cz && typstitek == TypPracStitek.cviceni)
            {
                return 1.2;
            }
            else if (jazyk == Jazyk.eng && typstitek == TypPracStitek.cviceni)
            {
                return 1.8;
            }
            return 0;
        }        
    }
}
