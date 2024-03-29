﻿using System;
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
                listBoxPredm.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listpredmetu[i].nazevpredmetu });
            }
            for (int i = 0; i < allObjects.listskupinky.Count; i++)
            {
                listBoxSkup.Items.Add(new UTB_PO_Stejskal.ListBoxItem() { id = i, nazev = allObjects.listskupinky[i].Nazev.Trim() == "" ? "Neni zadán název" : allObjects.listskupinky[i].Nazev.Trim() });
            }
        }

        private void spoj_Click(object sender, EventArgs e)
        {
            ListBoxItem vysledekpredmet = listBoxPredm.SelectedItem as ListBoxItem;
            ListBoxItem vysledekskupina = listBoxSkup.SelectedItem as ListBoxItem;
            if (this.allObjects.listpredmetu[vysledekpredmet.id].SeznamSkupin.Contains(this.allObjects.listskupinky[vysledekskupina.id]))
            {
                MessageBox.Show("Daný předmět danou skupinu obsahuje");
                return;
            }

            Predmet mujpredmet = this.allObjects.listpredmetu[vysledekpredmet.id];
            Skupinka mujskupina = this.allObjects.listskupinky[vysledekskupina.id];
            this.allObjects.listpredmetu[vysledekpredmet.id].SeznamSkupin.Add(this.allObjects.listskupinky[vysledekskupina.id]);
            //SeznamStitku seznamos = new SeznamStitku();
            allObjects.listpracovnichstitku.Add(new PracovniStitek() { JazykStitek=mujpredmet.Jazyk, Nazev = mujpredmet.nazevpredmetu+" - prednaska ", Predmet=mujpredmet, typ=TypPracStitek.prednaska, PocetHodin=mujpredmet.hodinyprednasek, PocetTydnu=mujpredmet.pocettydnu, PocetStudentu=mujskupina.PocetStudentu,  }) ;
            int pocetstitku = vratpocetstitku(mujskupina.PocetStudentu, mujpredmet.velikosttridy);
            int pocetstudentu = pocetstudentunastitek(mujskupina.PocetStudentu, pocetstitku);
            for (int i = 0; i < pocetstitku; i++)
            {
                allObjects.listpracovnichstitku.Add(new PracovniStitek() { JazykStitek = mujpredmet.Jazyk, Nazev = mujpredmet.nazevpredmetu+" - cviceni "+i+".", Predmet = mujpredmet, typ = TypPracStitek.cviceni, PocetHodin = mujpredmet.hodinycviceni, PocetStudentu=pocetstudentu, PocetTydnu=mujpredmet.pocettydnu  });
            }

            XMLObject obj = new XMLObject();

            obj.Serialize(this.allObjects);

        }

        int vratpocetstitku(int pocetstudentu, int velikosttridy)
        {
            double cislo = Math.Ceiling((double)pocetstudentu / velikosttridy);
            return (int)cislo;
        }

        int pocetstudentunastitek(int pocetstudentu, int stitku)
        {
            double cislo = Math.Ceiling((double)pocetstudentu / stitku);
            return (int)cislo;
        }
    }
}
