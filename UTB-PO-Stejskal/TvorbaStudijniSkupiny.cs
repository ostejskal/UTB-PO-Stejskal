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
            combojazyk.DataSource = Enum.GetValues(typeof(Jazyk));
            combotyp.DataSource = Enum.GetValues(typeof(TypStudia));
            comboforma.DataSource = Enum.GetValues(typeof(FormaStudia));
            combosemestr.DataSource = Enum.GetValues(typeof(Semestr));
        }

        private void oktvorbaskupiny_Click(object sender, EventArgs e)
        {
            try
            {
                Skupinka novaskupinka = new Skupinka();
                novaskupinka.Zkratka = textBox9.Text ?? "";
                if (textBox8.Text != "") novaskupinka.Rocnik = int.Parse(textBox8.Text);
                if (textBox6.Text != "") novaskupinka.PocetStudentu = int.Parse(textBox6.Text);
                novaskupinka.Nazev = textBox2.Text ?? "";
                TypStudia typstudia;
                Enum.TryParse<TypStudia>(combotyp.SelectedValue.ToString(), out typstudia);
                comboforma.DataSource = Enum.GetValues(typeof(FormaStudia));
                FormaStudia formastudia;
                Enum.TryParse<FormaStudia>(comboforma.SelectedValue.ToString(), out formastudia);
                combojazyk.DataSource = Enum.GetValues(typeof(Jazyk));
                Jazyk jazyk;
                Enum.TryParse<Jazyk>(combojazyk.SelectedValue.ToString(), out jazyk);
                combosemestr.DataSource = Enum.GetValues(typeof(Semestr));
                Semestr semestr;
                Enum.TryParse<Semestr>(combosemestr.SelectedValue.ToString(), out semestr);
                if (typstudia != null)
                novaskupinka.TypStudia = typstudia;
                if (formastudia != null)
                    novaskupinka.FormaStudia = formastudia;
                if (jazyk != null)
                    novaskupinka.Jazyk = jazyk;
                if (semestr != null)
                    novaskupinka.Semestr = semestr;


                XMLObject obj = new XMLObject();
                allObjects.listskupinky.Add(novaskupinka);
                obj.Serialize(allObjects);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Chyba při přidávání předmětu: " + ex.Message); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
