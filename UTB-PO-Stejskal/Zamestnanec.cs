using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    class Zamestnanec
    {
        String Jmeno;
        String Prijmeni;
        String Cele_Jmeno;//doplnit: Celé jméno – Jméno + Příjmení – Pavel Vařacha
        String PracovniEmail;
        String SoukromyEmail;
        bool Doktorand;
        double Uvazek;
        List<PracovniStitek> SeznamStitku;
        String PracovniTelefon;
        String SoukromyTelefon;
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
