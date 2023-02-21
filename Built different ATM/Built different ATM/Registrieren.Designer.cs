namespace Built_different_ATM
{
    partial class Registrieren
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
            this.benutzernameTextBox = new System.Windows.Forms.TextBox();
            this.passwortTextBox = new System.Windows.Forms.TextBox();
            this.passwortLabel = new System.Windows.Forms.Label();
            this.benutzernameLabel = new System.Windows.Forms.Label();
            this.passwortBestätigungTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bestätigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // benutzernameTextBox
            // 
            this.benutzernameTextBox.Location = new System.Drawing.Point(282, 80);
            this.benutzernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.benutzernameTextBox.Name = "benutzernameTextBox";
            this.benutzernameTextBox.Size = new System.Drawing.Size(284, 31);
            this.benutzernameTextBox.TabIndex = 42;
            // 
            // passwortTextBox
            // 
            this.passwortTextBox.Location = new System.Drawing.Point(282, 224);
            this.passwortTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwortTextBox.Name = "passwortTextBox";
            this.passwortTextBox.PasswordChar = '*';
            this.passwortTextBox.Size = new System.Drawing.Size(284, 31);
            this.passwortTextBox.TabIndex = 41;
            // 
            // passwortLabel
            // 
            this.passwortLabel.AutoSize = true;
            this.passwortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwortLabel.Location = new System.Drawing.Point(329, 149);
            this.passwortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwortLabel.Name = "passwortLabel";
            this.passwortLabel.Size = new System.Drawing.Size(161, 38);
            this.passwortLabel.TabIndex = 40;
            this.passwortLabel.Text = "Passwort";
            // 
            // benutzernameLabel
            // 
            this.benutzernameLabel.AutoSize = true;
            this.benutzernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.benutzernameLabel.Location = new System.Drawing.Point(288, 9);
            this.benutzernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.benutzernameLabel.Name = "benutzernameLabel";
            this.benutzernameLabel.Size = new System.Drawing.Size(241, 38);
            this.benutzernameLabel.TabIndex = 39;
            this.benutzernameLabel.Text = "Benutzername";
            // 
            // passwortBestätigungTextBox
            // 
            this.passwortBestätigungTextBox.Location = new System.Drawing.Point(282, 368);
            this.passwortBestätigungTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwortBestätigungTextBox.Name = "passwortBestätigungTextBox";
            this.passwortBestätigungTextBox.PasswordChar = '*';
            this.passwortBestätigungTextBox.Size = new System.Drawing.Size(284, 31);
            this.passwortBestätigungTextBox.TabIndex = 44;
            this.passwortBestätigungTextBox.TextChanged += new System.EventHandler(this.passwortBestätigungTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 38);
            this.label1.TabIndex = 43;
            this.label1.Text = "Passwort bestätigen";
            // 
            // Bestätigen
            // 
            this.Bestätigen.Location = new System.Drawing.Point(329, 451);
            this.Bestätigen.Name = "Bestätigen";
            this.Bestätigen.Size = new System.Drawing.Size(200, 34);
            this.Bestätigen.TabIndex = 45;
            this.Bestätigen.Text = "Bestätigen";
            this.Bestätigen.UseVisualStyleBackColor = true;
            this.Bestätigen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 531);
            this.Controls.Add(this.Bestätigen);
            this.Controls.Add(this.passwortBestätigungTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.benutzernameTextBox);
            this.Controls.Add(this.passwortTextBox);
            this.Controls.Add(this.passwortLabel);
            this.Controls.Add(this.benutzernameLabel);
            this.Name = "Registrieren";
            this.Text = "Registrieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox benutzernameTextBox;
        private TextBox passwortTextBox;
        private Label passwortLabel;
        private Label benutzernameLabel;
        private TextBox passwortBestätigungTextBox;
        private Label label1;
        private Button Bestätigen;
    }
}