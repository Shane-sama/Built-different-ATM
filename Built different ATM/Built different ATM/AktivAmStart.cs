using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Built_different_ATM
{
    public partial class AktivAmStart : Form
    {
        public AktivAmStart()
        {
            InitializeComponent();
        }

        public static string Benutzername = "";
        public static double Geldbetrag = 0;

        private void AktivAmStart_Load(object sender, EventArgs e)
        {
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Hide();
        }
    }
}
