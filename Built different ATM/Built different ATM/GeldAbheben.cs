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
    public partial class GeldAbheben : Form
    {
        public GeldAbheben()
        {
            InitializeComponent();
            Benutzer.Text = AktivAmStart.Benutzername;
            Guthaben.Text = Convert.ToString(AktivAmStart.Geldbetrag) + " CHF";
        }

        private void GeldAbheben_Load(object sender, EventArgs e)
        {

        }

        private void Zurück_Click(object sender, EventArgs e)
        {
            var Hauptseite = new Hauptseite();
            Hauptseite.Show();
            this.Close();
        }
    }
}
