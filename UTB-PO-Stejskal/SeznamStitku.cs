using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTB_PO_Stejskal
{
    public partial class SeznamStitku : Form
    {
        public AllObjects allObjects;
        public SeznamStitku()
        {
            InitializeComponent();
            XMLObject obj = new XMLObject();
            allObjects = obj.DeSerialize();
            listBox1.Items.Add("testovaci");
            for (int i = 0; i < allObjects.listpracovnichstitku.Count; i++)
            {
                listBox1.Items.Add("neco");
                listBox1.Items.Add(allObjects.listpracovnichstitku[i]);
            }
        }

    }
}
