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
        public AllObjects allObjects;
        public TvorbaStudijniSkupiny()
        {
            InitializeComponent();
            XMLObject obj = new XMLObject();
            allObjects = obj.DeSerialize();
        }

        private void oktvorbaskupiny_Click(object sender, EventArgs e)
        {
            try
            {
                Skupinka novaskupinka = new Skupinka();
                novaskupinka.Zkratka = textBox9.Text ?? "";
                if (textBox8.Text != "") novaskupinka.Rocnik = int.Parse(textBox8.Text);
                if (textBox6.Text != "") novaskupinka.PocetStudentu = int.Parse(textBox6.Text);
                novaskupinka.Nazev = textBox1.Text ?? "";
                XMLObject obj = new XMLObject();
                allObjects.listskupinky.Add(novaskupinka);
                obj.Serialize(allObjects);
            }
            catch (Exception ex) { MessageBox.Show("Chyba při přidávání předmětu: " + ex.Message); }
        }
    }
}
