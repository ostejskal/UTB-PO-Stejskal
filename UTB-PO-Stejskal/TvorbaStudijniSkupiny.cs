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
    public partial class TvorbaStudijniSkupiny : Form
    {
        public TvorbaStudijniSkupiny()
        {
            InitializeComponent();
        }

        private void oktvorbaskupiny_Click(object sender, EventArgs e)
        {
            Skupinka novaskupinka = new Skupinka();
            novaskupinka.Zkratka = textBox9.Text;
            novaskupinka.Rocnik = int.Parse(textBox8.Text);
            novaskupinka.PocetStudentu = int.Parse(textBox6.Text);
            novaskupinka.Nazev = textBox1.Text;
        }
    }
}
