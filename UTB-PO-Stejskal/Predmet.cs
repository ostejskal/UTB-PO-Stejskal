using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    class Predmet
    {
        String Zkratka;
        int PocetTydnu = 14;
        int HodinyPrednasek;
        int HodinyCviceni;
        int HodinySeminaru;
        enum ZpusobZakonceni { z, zk}
        enum Jazyk { cz, eng}
        int VelikostTridy = 24;
        List<Skupinka> SeznamSkupin;
        String NazevPredmetu;
        int PocetKreditu;
        enum GarantujiciUstav { UIUI, FAI}
        String JmenoGaranta;
    }
}
