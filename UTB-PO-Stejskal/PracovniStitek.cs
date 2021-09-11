using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    enum TypPracStitek { prednaska, cviceni, seminar, zapocet, klasifikovany_zapocet, zkouska }
    enum JazykStitek { cz , eng}
    public class PracovniStitek
    {
        String Nazev;
        Zamestnanec Zamestnanec = new Zamestnanec();
        Predmet Predmet = new Predmet();
        TypPracStitek typ;
        int PocetStudentu;
        int PocetHodin;
        int PocetTydnu;
        JazykStitek JazykStitek;
        public int PocetBoduZaPracovniStitek ()
        {
            return 0;
        }
    }
}
