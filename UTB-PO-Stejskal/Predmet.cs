using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    enum GarantujiciUstav { UIUI, FAI }
    //enum Jazyk { cz, eng }
    enum ZpusobZakonceni { z, zk }
    public class Predmet
    {
        String Zkratka;
        public String zkratka
        {
            get { return Zkratka; }
            set { Zkratka = value; }
        }
        int PocetTydnu = 14;
        public int pocettydnu
        {
            get { return PocetTydnu; }
            set { PocetTydnu = value; }
        }
        int HodinyPrednasek;
        public int hodinyprednasek
        {
            get { return HodinyPrednasek; }
            set { HodinyPrednasek = value; }
        }
        int HodinyCviceni;
        public int hodinycviceni
        {
            get { return HodinyCviceni; }
            set { HodinyCviceni = value; }
        }
        int HodinySeminaru;
        public int hodinyseminaru
        {
            get { return HodinySeminaru; }
            set { HodinySeminaru = value; }
        }
        ZpusobZakonceni ZpusobZakonceni;
        Jazyk Jazyk;
        int VelikostTridy = 24;
        public int velikosttridy
        {
            get { return VelikostTridy; }
            set { VelikostTridy = value; }
        }
        List<Skupinka> SeznamSkupin;
        String NazevPredmetu;
        public String nazevpredmetu
        {
            get { return NazevPredmetu; }
            set { NazevPredmetu = value; }
        }
        int PocetKreditu;
        public int pocetkreditu { get; set; }
        //{
        //    get { return PocetKreditu; }
        //    set { PocetKreditu = value; }
        //}
        GarantujiciUstav GarantujiciUstav;
        public String JmenoGaranta { get; set; }
        public Predmet()
        {
            
        }
    }
}
