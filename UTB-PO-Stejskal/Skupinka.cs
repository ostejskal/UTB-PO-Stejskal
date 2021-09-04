using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    enum Semestr { LS, ZS }
    enum FormaStudia { P, K }
    enum TypStudia { Bc, Mgr }
    enum Jazyk { cz, eng }
    class Skupinka
    {
        string Zkratka;
        int Rocnik;
        Semestr Semestr;
        int PocetStudentu;
        FormaStudia FormaStudia;
        TypStudia TypStudia;
        Jazyk Jazyk;
        String Nazev;
        List<Predmet> SeznamPredmetu;
    }
}
