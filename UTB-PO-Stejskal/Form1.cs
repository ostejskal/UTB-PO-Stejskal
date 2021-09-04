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
    }
}
