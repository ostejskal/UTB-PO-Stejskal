using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    enum GarantujiciUstav { UIUI, FAI }
    enum Jazyk { cz, eng }
    enum ZpusobZakonceni { z, zk }
    class Predmet
    {
        String Zkratka;
        int PocetTydnu = 14;
        int HodinyPrednasek;
        int HodinyCviceni;
        int HodinySeminaru;
        ZpusobZakonceni ZpusobZakonceni;
        Jazyk Jazyk;
        int VelikostTridy = 24;
        List<Skupinka> SeznamSkupin;
        String NazevPredmetu;
        int PocetKreditu;
        GarantujiciUstav GarantujiciUstav;
        String JmenoGaranta;
    }
}
