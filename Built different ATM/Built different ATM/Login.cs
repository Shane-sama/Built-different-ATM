using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Built_different_ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void benutzernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void einloggenBtn_Click(object sender, EventArgs e)
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
            try
            {
                int Count = 0;
                for(int i = 0; i < Nutzername.Length; i++)
                {
                    if (Nutzername[i] == benutzernameTextBox.Text && Passwort[i] == passwortTextBox.Text)
                    {
                        AktivAmStart.Benutzername = Nutzername[i];
                        AktivAmStart.Geldbetrag = Convert.ToDouble(Betrag[i]);
                        var Hauptseite = new Hauptseite();
                        Hauptseite.Show();
                        this.Close();
                    }else
                    {
                        Count++;
                        if(Count == Nutzername.Length)
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch
            {
                var ErrorLogin = new PopUpLoginFail();
                ErrorLogin.Show();
                this.Hide();
            }
    }

        private void passwortTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Registrieren_Click(object sender, EventArgs e)
        {
            var Registration = new Registrieren();
            Registration.Show();
            this.Close();
        }

        private void Schliessen_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

