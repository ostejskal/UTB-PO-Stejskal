using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    public enum Semestr { LS, ZS }
    public enum FormaStudia { P, K }
    public enum TypStudia { Bc, Mgr }
    public enum Jazyk { cz, eng }
    public class Skupinka
    {
        public string Zkratka { get; set; }
        public int Rocnik { get; set; }
        public Semestr Semestr { get; set; }
        public int PocetStudentu { get; set; }
        public FormaStudia FormaStudia { get; set; }
        public TypStudia TypStudia { get; set; }
        public Jazyk Jazyk { get; set; }
        public String Nazev { get; set; }
        public List<Predmet> SeznamPredmetu;
    }
}
