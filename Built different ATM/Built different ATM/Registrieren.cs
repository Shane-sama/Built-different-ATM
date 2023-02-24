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
    public partial class Registrieren : Form
    {
        public Registrieren()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            bool Benutzervorhanden = false;

            for (int i = 0; i < Nutzername.Length; i++)
            {
                if (Nutzername[i] == benutzernameTextBox.Text)
                {
                    Benutzervorhanden = true;
                    var RegistrationFail = new RegistrationsFail();
                    RegistrationFail.Show();
                    this.Close();
                }
            }
            
            if(Benutzervorhanden == false)
            {
                if (passwortTextBox.Text == passwortBestätigungTextBox.Text)
                {
                    string outPath = @"..\..\..\Accounts.csv";
                    string outText = "";
                    for (int a = 0; a < Nutzername.Length; a++)
                    {
                        outText = outText + Nutzername[a] + "," + Passwort[a] + "," + Betrag[a] + @"
";
                    }
                    outText = outText + benutzernameTextBox.Text + "," + passwortBestätigungTextBox.Text + "," + 0;
                    File.WriteAllText(outPath, outText);
                    var Login = new Login();
                    Login.Show();
                    this.Close();
                }
                else
                {
                    var RegistrationFail = new RegistrationsFail();
                    RegistrationFail.Show();
                    this.Close();
                }
            }
        }

        private void ausloggenBtn_Click(object sender, EventArgs e)
        {

        }

        private void passwortBestätigungTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
