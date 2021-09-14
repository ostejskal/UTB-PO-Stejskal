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

    public partial class PropojeniPredmetuSkupin : Form
    {
        public AllObjects allObjects;
        public PropojeniPredmetuSkupin()
        {
            InitializeComponent();
            XMLObject obj = new XMLObject();
            allObjects = obj.DeSerialize();
            for (int i = 0; i < allObjects.listpredmetu.Count; i++)
            {
                listBoxPredm.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listpredmetu[i].nazevpredmetu } );
            }
            for (int i = 0; i < allObjects.listskupinky.Count; i++)
            {
                listBoxSkup.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listskupinky[i].Nazev });
            }
        }

        private void spoj_Click(object sender, EventArgs e)
        {
            ListBoxItem vysledekpredmet = listBoxPredm.SelectedItem as ListBoxItem;
            ListBoxItem vysledekskupina = listBoxSkup.SelectedItem as ListBoxItem;
            if (this.allObjects.listpredmetu[vysledekpredmet.id].SeznamSkupin.Contains(this.allObjects.listskupinky[vysledekskupina.id]))
                MessageBox.Show("Daný předmět danou skupinu obsahuje");
            
            this.allObjects.listpredmetu[vysledekpredmet.id].SeznamSkupin.Add(this.allObjects.listskupinky[vysledekskupina.id]);
            XMLObject obj = new XMLObject();
            obj.Serialize(this.allObjects);

        }
    }
}
