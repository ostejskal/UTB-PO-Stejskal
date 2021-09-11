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
    public class Skupinka
    {
        public string Zkratka { get; set; }
        public int Rocnik { get; set; }
        Semestr Semestr;
        public int PocetStudentu { get; set; }
        FormaStudia FormaStudia;
        TypStudia TypStudia;
        Jazyk Jazyk;
        public String Nazev { get; set; }
        List<Predmet> SeznamPredmetu;
    }
}
