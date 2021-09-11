using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{
    public class AllObjects
    {
        public List<Skupinka> listskupinky { get; set; }
        public List<Zamestnanec> listzamestnancu { get; set; }
        public List<Predmet> listpredmetu {get; set;}
        public List<PracovniStitek> listpracovnichstitku { get; set; }

        public AllObjects()
        {
            listskupinky = new List<Skupinka>();
            listzamestnancu = new List<Zamestnanec>();
            listpredmetu = new List<Predmet>();
            listpracovnichstitku = new List<PracovniStitek>();

        }
    }
}
