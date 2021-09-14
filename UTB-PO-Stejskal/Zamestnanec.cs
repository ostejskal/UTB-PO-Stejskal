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
        public int PracovniBodyBezAnglictiny ()
        {
            return 0;
        }
        public int PracovniBody ()
        {
            return 0;
        }
    }
}
