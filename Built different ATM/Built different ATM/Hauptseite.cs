namespace Built_different_ATM
{
    public partial class Hauptseite : Form
    {
        public Hauptseite()
        {
            InitializeComponent();
            Benutzer.Text = AktivAmStart.Benutzername;
            Guthaben.Text = Convert.ToString(AktivAmStart.Geldbetrag) + " CHF";
        }
        
        private void ausloggenBtn_Click(object sender, EventArgs e)
        {
            string inPath = @"..\..\..\Accounts.csv";
            string text = File.ReadAllText(inPath);

            string[] lines = text.Split("\r\n");
            int words = lines.Length;
            string[] Nutzername = new string[words];
            string[] Passwort = new string[words];
            string[] Betrag = new string[words];

            for (int line = 0; line < lines.Length; line++)
            {
                try
                {
                    string[] items = lines[line].Split(',');
                    Nutzername[line] = items[0];
                    Passwort[line] = items[1];
                    Betrag[line] = items[2].Replace("\"", string.Empty); ;
                }
                catch
                {

                }
            }

            for(int i = 0; i < Nutzername.Length; i++)
            {
                if (Nutzername[i] == AktivAmStart.Benutzername)
                {
                    Betrag[i] = Convert.ToString(AktivAmStart.Geldbetrag);
                }
            }
            string outPath = @"..\..\..\Accounts.csv";
            string outText = "";
            for(int i = 0; i < Nutzername.Length; i++)
            {
                outText = outText + Nutzername[i] + "," + Passwort[i] + "," + Betrag[i] + @"
";
            }
            File.WriteAllText(outPath, outText);

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

        private void Hauptseite_Load(object sender, EventArgs e)
        {

        }
    }
}