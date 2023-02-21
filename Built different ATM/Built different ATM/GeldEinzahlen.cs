using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Built_different_ATM
{
    public partial class GeldEinzahlen : Form
    {
        public GeldEinzahlen()
        {
            InitializeComponent();
            Benutzer.Text = AktivAmStart.Benutzername;
            Guthaben.Text = Convert.ToString(AktivAmStart.Geldbetrag) + " CHF";
        }

        private void GeldEinzahlen_Load(object sender, EventArgs e)
        {

        }

        private void Zurück_Click(object sender, EventArgs e)
        {
            var Hauptseite = new Hauptseite();
            Hauptseite.Show();
            this.Close();
        }

        private void btn10CHF_Click(object sender, EventArgs e)
        {
            AktivAmStart.Geldbetrag = AktivAmStart.Geldbetrag + 10;
            var Bestätigung = new PopUpEinzahlen();
            Bestätigung.Show();
            this.Close();
        }

        private void btn20CHF_Click(object sender, EventArgs e)
        {
            AktivAmStart.Geldbetrag = AktivAmStart.Geldbetrag + 20;
            var Bestätigung = new PopUpEinzahlen();
            Bestätigung.Show();
            this.Close();
        }

        private void btn50CHF_Click(object sender, EventArgs e)
        {
            AktivAmStart.Geldbetrag = AktivAmStart.Geldbetrag + 50;
            var Bestätigung = new PopUpEinzahlen();
            Bestätigung.Show();
            this.Close();
        }

        private void btn100CHF_Click(object sender, EventArgs e)
        {
            AktivAmStart.Geldbetrag = AktivAmStart.Geldbetrag + 100;
            var Bestätigung = new PopUpEinzahlen();
            Bestätigung.Show();
            this.Close();
        }

        private void btn200CHF_Click(object sender, EventArgs e)
        {
            AktivAmStart.Geldbetrag = AktivAmStart.Geldbetrag + 200;
            var Bestätigung = new PopUpEinzahlen();
            Bestätigung.Show();
            this.Close();
        }

        private void btn500CHF_Click(object sender, EventArgs e)
        {
            AktivAmStart.Geldbetrag = AktivAmStart.Geldbetrag + 500;
            var Bestätigung = new PopUpEinzahlen();
            Bestätigung.Show();
            this.Close();
        }
    }
}
