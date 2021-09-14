using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB_PO_Stejskal
{

    public class ListBoxItem
    {
        public int id { get; set; }
        public string nazev { get; set; }

        public override string ToString()
        {
            return nazev;
        }



    }
}
