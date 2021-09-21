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
        Cilinder objCilinder;

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
                if (radioButton1.Checked)
                {
                    objCilinder = new Cilinder(doubleBreedte, doubleHoogte);
                } else

              objBalk = new Balk(doubleLengte, doubleBreedte, doubleHoogte);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            if(txtVoornaam.Text == "" || txtAchternaam.Text == "" || txtAdres.Text == "" || txtPostcode.Text == "")
            {
                MessageBox.Show("Vul alle velden in!");
                this.Close();
            }
            else
            {
                bon();
            }
        }
      
        void bon()
        {
           
            string kubusBalk;
            string uitkomst;
            string kosten;
            
            
            if (radioButton1.Checked)
            {
                kubusBalk = "Cilindervormige bloembak";
                uitkomst = "Inhoud bloembak: " + objCilinder.VolumeCilinder + "m3";
                pictureBox1.Image = Properties.Resources.cilinder2;
            }
            else if (objBalk.Iskubus == true)
            {
                kubusBalk = "Kubusvormige bloembak";
                uitkomst = "Inhoud bloembak: " + objBalk.Volume + "m3";
                pictureBox1.Image = Properties.Resources.kubus;
            }
            else
            {
                kubusBalk = "Balkvormige bloembak";
                uitkomst = "Inhoud bloembak: " + objBalk.Volume + "m3";
                pictureBox1.Image = Properties.Resources.rechthoekig_balk;
            }
            if (radioButton1.Checked)
            {
                if (objCilinder.VolumeCilinder <= 0.2)
                {
                    kosten = "$40";
                }
                else if (objCilinder.VolumeCilinder >= 0.2 && objCilinder.VolumeCilinder <= 0.4)
                {
                    kosten = "$80";
                }
                else if (objCilinder.VolumeCilinder >= 0.4 && objCilinder.VolumeCilinder <= 0.6)
                {
                    kosten = "$140";
                }
                else if (objCilinder.VolumeCilinder >= 0.6 && objCilinder.VolumeCilinder <= 0.8)
                {
                    kosten = "$210";
                }
                else
                {
                    kosten = "$250";
                }
            }
            else
            {
                if (objBalk.Volume <= 0.2)
                {
                    kosten = "$40";
                }
                else if (objBalk.Volume >= 0.2 && objBalk.Volume <= 0.4)
                {
                    kosten = "$80";
                }
                else if (objBalk.Volume >= 0.4 && objBalk.Volume <= 0.6)
                {
                    kosten = "$140";
                }
                else if (objBalk.Volume >= 0.6 && objBalk.Volume <= 0.8)
                {
                    kosten = "$210";
                }
                else
                {
                    kosten = "$250";
                }
            }
            
                txtBon.Text = "";

            txtBon.Text = "Klant: " + Environment.NewLine
            + txtVoornaam.Text + " " + txtTussenvoegsel.Text + " " + txtAchternaam.Text + Environment.NewLine
            + txtAdres.Text + Environment.NewLine
            + txtPostcode.Text + Environment.NewLine
            + Environment.NewLine + "Bestelling: " + kubusBalk
            + Environment.NewLine + "Lengte: " + txtLengte.Text + Environment.NewLine + "Breedte: " + txtBreedte.Text + Environment.NewLine + "Hoogte: " + txtHoogte.Text
            + Environment.NewLine
            + Environment.NewLine
            + uitkomst
            + Environment.NewLine
            + "Prijs van de pot: " + kosten;

            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtLengte.Enabled = false;
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
