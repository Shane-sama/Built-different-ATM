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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Geldeinzahlen
            // 
            this.Geldeinzahlen.Location = new System.Drawing.Point(50, 300);
            this.Geldeinzahlen.Name = "Geldeinzahlen";
            this.Geldeinzahlen.Size = new System.Drawing.Size(260, 80);
            this.Geldeinzahlen.TabIndex = 0;
            this.Geldeinzahlen.Tag = "einzahlen";
            this.Geldeinzahlen.Text = "Geld einzahlen";
            this.Geldeinzahlen.UseVisualStyleBackColor = true;
            // 
            // Geldabheben
            // 
            this.Geldabheben.Location = new System.Drawing.Point(450, 300);
            this.Geldabheben.Name = "Geldabheben";
            this.Geldabheben.Size = new System.Drawing.Size(260, 80);
            this.Geldabheben.TabIndex = 1;
            this.Geldabheben.Tag = "abheben";
            this.Geldabheben.Text = "Geld abheben";
            this.Geldabheben.UseVisualStyleBackColor = true;
            // 
            // Geld
            // 
            this.Geld.Location = new System.Drawing.Point(450, 30);
            this.Geld.Name = "Geld";
            this.Geld.Size = new System.Drawing.Size(80, 27);
            this.Geld.TabIndex = 2;
            this.Geld.Text = "Guthaben:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Benutzer:";
            // 
            // Hauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Geld);
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
        private TextBox textBox1;
    }
}