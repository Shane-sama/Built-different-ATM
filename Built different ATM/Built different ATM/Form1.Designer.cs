namespace Built_different_ATM
{
    partial class Hauptseite
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Geldeinzahlen = new System.Windows.Forms.Button();
            this.Geldabheben = new System.Windows.Forms.Button();
            this.Geld = new System.Windows.Forms.TextBox();
            this.Benutzer = new System.Windows.Forms.TextBox();
            this.ausloggenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Geldeinzahlen
            // 
            this.Geldeinzahlen.BackColor = System.Drawing.Color.GhostWhite;
            this.Geldeinzahlen.Location = new System.Drawing.Point(189, 130);
            this.Geldeinzahlen.Name = "Geldeinzahlen";
            this.Geldeinzahlen.Size = new System.Drawing.Size(179, 80);
            this.Geldeinzahlen.TabIndex = 0;
            this.Geldeinzahlen.Tag = "einzahlen";
            this.Geldeinzahlen.Text = "Geld einzahlen";
            this.Geldeinzahlen.UseVisualStyleBackColor = false;
            // 
            // Geldabheben
            // 
            this.Geldabheben.BackColor = System.Drawing.Color.GhostWhite;
            this.Geldabheben.Location = new System.Drawing.Point(428, 130);
            this.Geldabheben.Name = "Geldabheben";
            this.Geldabheben.Size = new System.Drawing.Size(179, 80);
            this.Geldabheben.TabIndex = 1;
            this.Geldabheben.Tag = "abheben";
            this.Geldabheben.Text = "Geld abheben";
            this.Geldabheben.UseVisualStyleBackColor = false;
            // 
            // Geld
            // 
            this.Geld.Location = new System.Drawing.Point(463, 31);
            this.Geld.Name = "Geld";
            this.Geld.Size = new System.Drawing.Size(94, 27);
            this.Geld.TabIndex = 22;
            this.Geld.Text = "Guthaben:";
            // 
            // Benutzer
            // 
            this.Benutzer.Location = new System.Drawing.Point(227, 31);
            this.Benutzer.Name = "Benutzer";
            this.Benutzer.Size = new System.Drawing.Size(94, 27);
            this.Benutzer.TabIndex = 21;
            this.Benutzer.Text = "Benutzer:";
            // 
            // ausloggenBtn
            // 
            this.ausloggenBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ausloggenBtn.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ausloggenBtn.Location = new System.Drawing.Point(336, 292);
            this.ausloggenBtn.Name = "ausloggenBtn";
            this.ausloggenBtn.Size = new System.Drawing.Size(125, 52);
            this.ausloggenBtn.TabIndex = 23;
            this.ausloggenBtn.Text = "Ausloggen";
            this.ausloggenBtn.UseVisualStyleBackColor = false;
            // 
            // Hauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.ausloggenBtn);
            this.Controls.Add(this.Geld);
            this.Controls.Add(this.Benutzer);
            this.Controls.Add(this.Geldabheben);
            this.Controls.Add(this.Geldeinzahlen);
            this.Name = "Hauptseite";
            this.Text = "Hauptseite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Geldeinzahlen;
        private Button Geldabheben;
        private TextBox Geld;
        private TextBox Benutzer;
        private Button ausloggenBtn;
    }
}