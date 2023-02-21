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
            this.SuspendLayout();
            // 
            // einloggenBtn
            // 
            this.einloggenBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.einloggenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.einloggenBtn.Location = new System.Drawing.Point(415, 406);
            this.einloggenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.einloggenBtn.Name = "einloggenBtn";
            this.einloggenBtn.Size = new System.Drawing.Size(156, 65);
            this.einloggenBtn.TabIndex = 28;
            this.einloggenBtn.Text = "Einloggen";
            this.einloggenBtn.UseVisualStyleBackColor = false;
            this.einloggenBtn.Click += new System.EventHandler(this.einloggenBtn_Click);
            // 
            // benutzernameLabel
            // 
            this.benutzernameLabel.AutoSize = true;
            this.benutzernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.benutzernameLabel.Location = new System.Drawing.Point(361, 71);
            this.benutzernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.benutzernameLabel.Name = "benutzernameLabel";
            this.benutzernameLabel.Size = new System.Drawing.Size(241, 38);
            this.benutzernameLabel.TabIndex = 33;
            this.benutzernameLabel.Text = "Benutzername";
            // 
            // passwortLabel
            // 
            this.passwortLabel.AutoSize = true;
            this.passwortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwortLabel.Location = new System.Drawing.Point(402, 231);
            this.passwortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwortLabel.Name = "passwortLabel";
            this.passwortLabel.Size = new System.Drawing.Size(161, 38);
            this.passwortLabel.TabIndex = 36;
            this.passwortLabel.Text = "Passwort";
            // 
            // passwortTextBox
            // 
            this.passwortTextBox.Location = new System.Drawing.Point(355, 306);
            this.passwortTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwortTextBox.Name = "passwortTextBox";
            this.passwortTextBox.PasswordChar = '*';
            this.passwortTextBox.Size = new System.Drawing.Size(284, 31);
            this.passwortTextBox.TabIndex = 37;
            this.passwortTextBox.TextChanged += new System.EventHandler(this.passwortTextBox_TextChanged);
            // 
            // benutzernameTextBox
            // 
            this.benutzernameTextBox.Location = new System.Drawing.Point(355, 142);
            this.benutzernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.benutzernameTextBox.Name = "benutzernameTextBox";
            this.benutzernameTextBox.Size = new System.Drawing.Size(284, 31);
            this.benutzernameTextBox.TabIndex = 38;
            this.benutzernameTextBox.TextChanged += new System.EventHandler(this.benutzernameTextBox_TextChanged);
            // 
            // Registrieren
            // 
            this.Registrieren.Location = new System.Drawing.Point(415, 512);
            this.Registrieren.Name = "Registrieren";
            this.Registrieren.Size = new System.Drawing.Size(156, 42);
            this.Registrieren.TabIndex = 39;
            this.Registrieren.Text = "Registrieren";
            this.Registrieren.UseVisualStyleBackColor = true;
            this.Registrieren.Click += new System.EventHandler(this.Registrieren_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(978, 566);
            this.Controls.Add(this.Registrieren);
            this.Controls.Add(this.benutzernameTextBox);
            this.Controls.Add(this.passwortTextBox);
            this.Controls.Add(this.passwortLabel);
            this.Controls.Add(this.benutzernameLabel);
            this.Controls.Add(this.einloggenBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}