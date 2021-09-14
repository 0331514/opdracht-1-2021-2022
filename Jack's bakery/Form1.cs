using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jack_s_bakery
{
    public partial class Form1 : Form
    {
        Balk objBalk;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBestel_Click(object sender, EventArgs e)
        {

            double doubleLengte;
            double.TryParse(txtLengte.Text, out doubleLengte);

            double doubleBreedte;
            double.TryParse(txtBreedte.Text, out doubleBreedte);

            double doubleHoogte;
            double.TryParse(txtHoogte.Text, out doubleHoogte);

            try
            {
              objBalk = new Balk(doubleLengte, doubleBreedte, doubleHoogte);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(txtVoornaam.Text == "" || txtAchternaam.Text == "" || txtAdres.Text == "" || txtPostcode.Text == "")
            {
                MessageBox.Show("Vul alle velden in!");
            }
            else
            {
                bon();
            }
        }

        void bon()
        {
            string kubusBalk;
            if (objBalk.Iskubus == true)
            {
                kubusBalk = "Kubusvormige bloembak";
            }
            else
                kubusBalk = "Balkvormige bloembak";

            txtBon.Text = "";

            txtBon.Text = "Klant: " + Environment.NewLine
            + txtVoornaam.Text + " " + txtTussenvoegsel.Text + " " + txtAchternaam.Text + Environment.NewLine
            + txtAdres.Text + Environment.NewLine
            + txtPostcode.Text + Environment.NewLine
            + Environment.NewLine + "Bestelling: " + kubusBalk
            + Environment.NewLine + "Lengte: " + txtLengte.Text + Environment.NewLine + "Breedte: " + txtBreedte.Text + Environment.NewLine + "Hoogte: " + txtHoogte.Text
            + Environment.NewLine
            + Environment.NewLine + "Inhoud Bloembak: " + objBalk.Volume + " m3";

        }
    }
}
