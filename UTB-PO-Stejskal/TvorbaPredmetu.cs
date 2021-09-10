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
    public partial class TvorbaPredmetu : Form
    {
        public TvorbaPredmetu()
        {
            InitializeComponent();
        }

        private void oktvorbapredmet_Click(object sender, EventArgs e)
        {
            Predmet novypredmet = new Predmet();
            novypredmet.zkratka = textBox1.Text ?? "";
            if (textBox2.Text != "") novypredmet.pocettydnu = int.Parse(textBox2.Text);
            if (textBox3.Text != "") novypredmet.hodinyprednasek = int.Parse(textBox3.Text);
            if (textBox4.Text != "") novypredmet.hodinycviceni = int.Parse(textBox4.Text);
            if (textBox5.Text != "") novypredmet.hodinyseminaru = int.Parse(textBox5.Text);
            if (textBox8.Text != "") novypredmet.velikosttridy = int.Parse(textBox8.Text);
            novypredmet.nazevpredmetu = textBox10.Text ?? "";
            if (textBox11.Text != "") novypredmet.pocetkreditu = int.Parse(textBox11.Text);
            novypredmet.JmenoGaranta = textBox13.Text ?? "";
        }
    }
}
