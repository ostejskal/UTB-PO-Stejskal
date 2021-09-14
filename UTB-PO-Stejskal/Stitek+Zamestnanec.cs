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
    public partial class Stitek_Zamestnanec : Form
    {
        public AllObjects allObjects;
        public Stitek_Zamestnanec()
        {
            InitializeComponent();
            XMLObject obj = new XMLObject();
            allObjects = obj.DeSerialize();
            for (int i = 0; i < allObjects.listpracovnichstitku.Count; i++)
            {
                listBoxStitek.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listpracovnichstitku[i].Nazev });
            }

            for (int i = 0; i < allObjects.listzamestnancu.Count; i++)
            {
                listBoxZamestnanec.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listzamestnancu[i].prijmeni });
            }
        }

        private void spoj_Click(object sender, EventArgs e)
        {
            ListBoxItem vysledekstitek = listBoxStitek.SelectedItem as ListBoxItem;
            ListBoxItem vysledekzamestnanec = listBoxZamestnanec.SelectedItem as ListBoxItem;
            PracovniStitek mujstitek = this.allObjects.listpracovnichstitku[vysledekstitek.id];
            Zamestnanec mujzamestnanec = this.allObjects.listzamestnancu[vysledekzamestnanec.id];
            this.allObjects.listzamestnancu[vysledekzamestnanec.id].SeznamStitku.Add(this.allObjects.listpracovnichstitku[vysledekstitek.id]);
            //allObjects..Add(new PracovniStitek() { JazykStitek = mujpredmet.Jazyk, Nazev = mujpredmet.nazevpredmetu + " - prednaska ", Predmet = mujpredmet, typ = TypPracStitek.prednaska, PocetHodin = mujpredmet.hodinyprednasek, PocetTydnu = mujpredmet.pocettydnu, PocetStudentu = mujskupina.PocetStudentu, });
        }
    }
}
