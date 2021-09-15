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
            
        }

        private void spoj_Click(object sender, EventArgs e)
        {
            ListBoxItem vysledekstitek = listBoxStitek.SelectedItem as ListBoxItem;
            ListBoxItem vysledekzamestnanec = listBoxZamestnanec.SelectedItem as ListBoxItem;
            PracovniStitek mujstitek = this.allObjects.listpracovnichstitku[vysledekstitek.id];
            Zamestnanec mujzamestnanec = this.allObjects.listzamestnancu[vysledekzamestnanec.id];
            //this.allObjects.listpracovnichstitku[vysledekstitek.id].Zamestnanec = mujzamestnanec;
            this.allObjects.listzamestnancu[vysledekzamestnanec.id].SeznamStitku.Add(mujstitek);
            this.allObjects.listzamestnancu[vysledekzamestnanec.id].PracovniBody += PracovniBodycalc(mujstitek.typ, mujstitek.JazykStitek);
            XMLObject obj = new XMLObject();
            obj.Serialize(this.allObjects);
            //listBoxStitek.Items.RemoveAt(listBoxStitek.SelectedIndex);
        }

        public double PracovniBodycalc(TypPracStitek typstitek, Jazyk jazyk)
        {
            if (jazyk == Jazyk.cz && typstitek == TypPracStitek.prednaska)
            {
                return 1.8;
            }
            else if (jazyk == Jazyk.eng && typstitek == TypPracStitek.prednaska)
            {
                return 2.4;
            }
            else if (jazyk == Jazyk.cz && typstitek == TypPracStitek.cviceni)
            {
                return 1.2;
            }
            else if (jazyk == Jazyk.eng && typstitek == TypPracStitek.cviceni)
            {
                return 1.8;
            }
            return 0;
        }

        private void listBoxZamestnanec_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Stitek_Zamestnanec_Load(null, null);
        }

        private void Stitek_Zamestnanec_Load(object sender, EventArgs e)
        {
            XMLObject obj = new XMLObject();
            allObjects = obj.DeSerialize();

            listBoxStitek.Items.Clear();

            if (listBoxZamestnanec.SelectedIndex == -1)
                for (int i = 0; i < allObjects.listzamestnancu.Count; i++)
                {
                    listBoxZamestnanec.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listzamestnancu[i].prijmeni });
                }


            if (listBoxZamestnanec.SelectedIndex != -1)
            { 
                ListBoxItem vysledekstitek = listBoxStitek.SelectedItem as ListBoxItem;

                ListBoxItem vysledekzamestnanec = listBoxZamestnanec.SelectedItem as ListBoxItem;
                Zamestnanec mujzamestnanec = this.allObjects.listzamestnancu[vysledekzamestnanec.id];

                for (int i = 0; i < allObjects.listpracovnichstitku.Count; i++)
                {
                    if (!mujzamestnanec.SeznamStitku.Contains(allObjects.listpracovnichstitku[i]))

                        listBoxStitek.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listpracovnichstitku[i].Nazev });
                }
            }
            
            
        }
    }
}
