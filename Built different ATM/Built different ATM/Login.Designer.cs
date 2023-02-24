namespace Built_different_ATM
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.einloggenBtn = new System.Windows.Forms.Button();
            this.benutzernameLabel = new System.Windows.Forms.Label();
            this.passwortLabel = new System.Windows.Forms.Label();
            this.passwortTextBox = new System.Windows.Forms.TextBox();
            this.benutzernameTextBox = new System.Windows.Forms.TextBox();
            this.Registrieren = new System.Windows.Forms.Button();
            this.Schliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // einloggenBtn
            // 
            this.einloggenBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.einloggenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.einloggenBtn.Location = new System.Drawing.Point(332, 325);
            this.einloggenBtn.Name = "einloggenBtn";
            this.einloggenBtn.Size = new System.Drawing.Size(125, 52);
            this.einloggenBtn.TabIndex = 28;
            this.einloggenBtn.Text = "Einloggen";
            this.einloggenBtn.UseVisualStyleBackColor = false;
            this.einloggenBtn.Click += new System.EventHandler(this.einloggenBtn_Click);
            // 
            // benutzernameLabel
            // 
            this.benutzernameLabel.AutoSize = true;
            this.benutzernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.benutzernameLabel.Location = new System.Drawing.Point(289, 57);
            this.benutzernameLabel.Name = "benutzernameLabel";
            this.benutzernameLabel.Size = new System.Drawing.Size(211, 32);
            this.benutzernameLabel.TabIndex = 33;
            this.benutzernameLabel.Text = "Benutzername";
            // 
            // passwortLabel
            // 
            this.passwortLabel.AutoSize = true;
            this.passwortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwortLabel.Location = new System.Drawing.Point(322, 185);
            this.passwortLabel.Name = "passwortLabel";
            this.passwortLabel.Size = new System.Drawing.Size(138, 32);
            this.passwortLabel.TabIndex = 36;
            this.passwortLabel.Text = "Passwort";
            // 
            // passwortTextBox
            // 
            this.passwortTextBox.Location = new System.Drawing.Point(284, 245);
            this.passwortTextBox.Name = "passwortTextBox";
            this.passwortTextBox.PasswordChar = '*';
            this.passwortTextBox.Size = new System.Drawing.Size(228, 27);
            this.passwortTextBox.TabIndex = 37;
            this.passwortTextBox.TextChanged += new System.EventHandler(this.passwortTextBox_TextChanged);
            // 
            // benutzernameTextBox
            // 
            this.benutzernameTextBox.Location = new System.Drawing.Point(284, 114);
            this.benutzernameTextBox.Name = "benutzernameTextBox";
            this.benutzernameTextBox.Size = new System.Drawing.Size(228, 27);
            this.benutzernameTextBox.TabIndex = 38;
            this.benutzernameTextBox.TextChanged += new System.EventHandler(this.benutzernameTextBox_TextChanged);
            // 
            // Registrieren
            // 
            this.Registrieren.Location = new System.Drawing.Point(332, 410);
            this.Registrieren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Registrieren.Name = "Registrieren";
            this.Registrieren.Size = new System.Drawing.Size(125, 34);
            this.Registrieren.TabIndex = 39;
            this.Registrieren.Text = "Registrieren";
            this.Registrieren.UseVisualStyleBackColor = true;
            this.Registrieren.Click += new System.EventHandler(this.Registrieren_Click);
            // 
            // Schliessen
            // 
            this.Schliessen.Location = new System.Drawing.Point(676, 413);
            this.Schliessen.Name = "Schliessen";
            this.Schliessen.Size = new System.Drawing.Size(94, 29);
            this.Schliessen.TabIndex = 40;
            this.Schliessen.Text = "Schliessen";
            this.Schliessen.UseVisualStyleBackColor = true;
            this.Schliessen.Click += new System.EventHandler(this.Schliessen_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Schliessen);
            this.Controls.Add(this.Registrieren);
            this.Controls.Add(this.benutzernameTextBox);
            this.Controls.Add(this.passwortTextBox);
            this.Controls.Add(this.passwortLabel);
            this.Controls.Add(this.benutzernameLabel);
            this.Controls.Add(this.einloggenBtn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button einloggenBtn;
        private Label benutzernameLabel;
        private Label passwortLabel;
        private TextBox passwortTextBox;
        private TextBox benutzernameTextBox;
        private Button Registrieren;
        private Button Schliessen;
    }
}