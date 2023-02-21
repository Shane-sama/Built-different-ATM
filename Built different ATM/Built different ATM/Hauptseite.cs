namespace Built_different_ATM
{
    public partial class Hauptseite : Form
    {
        public Hauptseite()
        {
            InitializeComponent();
            Benutzer.Text = AktivAmStart.Benutzername;
            Guthaben.Text = Convert.ToString(AktivAmStart.Geldbetrag);
        }
        
        private void ausloggenBtn_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Close();
        }


        private void Geldabheben_Click(object sender, EventArgs e)
        {
            var Abheben = new GeldAbheben();
            Abheben.Show();
            this.Close();
        }


        private void Geldeinzahlen_Click(object sender, EventArgs e)
        {
            var Einzahlen = new GeldEinzahlen();
            Einzahlen.Show();
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}