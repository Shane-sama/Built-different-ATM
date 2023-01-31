namespace Built_different_ATM
{
    public partial class Hauptseite : Form
    {

        public static Hauptseite instance;
        public Label GuthabenLable;
        public Label BenutzerLable;
        public Hauptseite()
        {
            InitializeComponent();
            instance = this;
            GuthabenLable = Guthaben;
            BenutzerLable = Benutzer;
        }
        
        private void ausloggenBtn_Click(object sender, EventArgs e)
        {
            Form L1 = new Login();
            L1.Show();
            this.Close();
        }


        private void Geldabheben_Click(object sender, EventArgs e)
        {

        }


        private void Geldeinzahlen_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}