using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    class Skupinka
    {
        string Zkratka;
        int Rocnik;
        enum Semestr { LS, ZS }
        int PocetStudentu;
        enum FormaStudia { P, K}
        enum TypStudia { Bc , Mgr  }
        enum Jazyk { cz , eng }
        String Nazev;
        List<Predmet> SeznamPredmetu;
    }
}
