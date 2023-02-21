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
    public partial class RegistrationsFail : Form
    {
        public RegistrationsFail()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            var Registration = new Registrieren();
            Registration.Show();
            this.Close();

        }
    }
}
