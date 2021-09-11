using System;
using System.Data;
using System.Windows.Forms;

namespace UTB_PO_Stejskal
{
    public partial class TvorbaZamestnance : Form
    {
        public AllObjects allObjects;
        public TvorbaZamestnance()
        {
            InitializeComponent();
            XMLObject obj = new XMLObject();
            allObjects = obj.DeSerialize();
        }

        private void oktvorbazamestnance_Click(object sender, EventArgs e)
        {
            try
            {
                Zamestnanec novyzamestnanec = new Zamestnanec();
                novyzamestnanec.jmeno = textBox5.Text ?? "";
                novyzamestnanec.prijmeni = textBox4.Text ?? "";
                novyzamestnanec.pracovniemail = textBox3.Text ?? "";
                novyzamestnanec.soukromyemail = textBox2.Text ?? "";
                if (textBox7.Text != "")
                {
                    novyzamestnanec.doktorand = bool.Parse(textBox7.Text);
                }
                if (textBox8.Text != "")
                {
                    novyzamestnanec.uvazek = Double.Parse(textBox8.Text);
                }
                novyzamestnanec.pracovnitelefon = textBox10.Text ?? "";
                novyzamestnanec.soukromytelefon = textBox11.Text ?? "";
                XMLObject obj = new XMLObject();
                allObjects.listzamestnancu.Add(novyzamestnanec);
                obj.Serialize(allObjects);
            }
            catch (Exception ex) { MessageBox.Show("Chyba při přidávání předmětu: " + ex.Message); }
        }
    }
}
