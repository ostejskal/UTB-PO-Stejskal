using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    public enum TypPracStitek { prednaska, cviceni, seminar, zapocet, klasifikovany_zapocet, zkouska }
    public class PracovniStitek
    {
        public String Nazev;
        public Zamestnanec Zamestnanec;
        public Predmet Predmet;
        public TypPracStitek typ;
        public int PocetStudentu;
        public int PocetHodin;
        public int PocetTydnu;
        public Jazyk JazykStitek;
        public int PocetBoduZaPracovniStitek ()
        {
            return 0;
        }
    }
}
