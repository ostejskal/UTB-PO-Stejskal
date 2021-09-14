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
    public partial class Hlavniokno : Form
    {
        public AllObjects allObjects;
        public Hlavniokno()
        {
            InitializeComponent();
        }

        private void tvorbapredmetu_Click(object sender, EventArgs e)
        {
            TvorbaPredmetu tvorba = new TvorbaPredmetu();
            tvorba.Show();
            Predmet novypredment = new Predmet();
        }

        private void tvorbaskupiny_Click(object sender, EventArgs e)
        {
            TvorbaStudijniSkupiny tvorbaskupinky = new TvorbaStudijniSkupiny();
            tvorbaskupinky.Show();
            Skupinka novaskupinka = new Skupinka();
        }

        private void tvorbazamestnance_Click(object sender, EventArgs e)
        {
            TvorbaZamestnance tvorbapracovnika = new TvorbaZamestnance();
            tvorbapracovnika.Show();
            Zamestnanec novyzamestnanec = new Zamestnanec();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeznamStitku seznam = new SeznamStitku();
            seznam.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PropojeniPredmetuSkupin propojeni = new PropojeniPredmetuSkupin();
            propojeni.Show();
        }

        private void generovanitlacitko_Click(object sender, EventArgs e)
        {
            PracovniStitek stitek = new PracovniStitek();
            
        }

        private int funkceprogenerovani()
        {
            
            return 0;
        }
    }
}
