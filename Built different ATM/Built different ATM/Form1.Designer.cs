﻿namespace Built_different_ATM
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
            this.ausloggenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Benutzer = new System.Windows.Forms.Label();
            this.Guthaben = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Geldeinzahlen
            // 
            this.Geldeinzahlen.BackColor = System.Drawing.Color.GhostWhite;
            this.Geldeinzahlen.Location = new System.Drawing.Point(165, 98);
            this.Geldeinzahlen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Geldeinzahlen.Name = "Geldeinzahlen";
            this.Geldeinzahlen.Size = new System.Drawing.Size(157, 60);
            this.Geldeinzahlen.TabIndex = 0;
            this.Geldeinzahlen.Tag = "einzahlen";
            this.Geldeinzahlen.Text = "Geld einzahlen";
            this.Geldeinzahlen.UseVisualStyleBackColor = false;
            this.Geldeinzahlen.Click += new System.EventHandler(this.Geldeinzahlen_Click);
            // 
            // Geldabheben
            // 
            this.Geldabheben.BackColor = System.Drawing.Color.GhostWhite;
            this.Geldabheben.Location = new System.Drawing.Point(374, 98);
            this.Geldabheben.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Geldabheben.Name = "Geldabheben";
            this.Geldabheben.Size = new System.Drawing.Size(157, 60);
            this.Geldabheben.TabIndex = 1;
            this.Geldabheben.Tag = "abheben";
            this.Geldabheben.Text = "Geld abheben";
            this.Geldabheben.UseVisualStyleBackColor = false;
            this.Geldabheben.Click += new System.EventHandler(this.Geldabheben_Click);
            // 
            // ausloggenBtn
            // 
            this.ausloggenBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ausloggenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ausloggenBtn.Location = new System.Drawing.Point(294, 219);
            this.ausloggenBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ausloggenBtn.Name = "ausloggenBtn";
            this.ausloggenBtn.Size = new System.Drawing.Size(109, 39);
            this.ausloggenBtn.TabIndex = 23;
            this.ausloggenBtn.Text = "Ausloggen";
            this.ausloggenBtn.UseVisualStyleBackColor = false;
            this.ausloggenBtn.Click += new System.EventHandler(this.ausloggenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Benutzer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Guthaben:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Benutzer
            // 
            this.Benutzer.AutoSize = true;
            this.Benutzer.Location = new System.Drawing.Point(230, 25);
            this.Benutzer.Name = "Benutzer";
            this.Benutzer.Size = new System.Drawing.Size(38, 15);
            this.Benutzer.TabIndex = 26;
            this.Benutzer.Text = "label3";
            // 
            // Guthaben
            // 
            this.Guthaben.AutoSize = true;
            this.Guthaben.Location = new System.Drawing.Point(450, 25);
            this.Guthaben.Name = "Guthaben";
            this.Guthaben.Size = new System.Drawing.Size(38, 15);
            this.Guthaben.TabIndex = 27;
            this.Guthaben.Text = "label4";
            // 
            // Hauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(684, 340);
            this.Controls.Add(this.Guthaben);
            this.Controls.Add(this.Benutzer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ausloggenBtn);
            this.Controls.Add(this.Geldabheben);
            this.Controls.Add(this.Geldeinzahlen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hauptseite";
            this.Text = "Hauptseite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Geldeinzahlen;
        private Button Geldabheben;
        private Button ausloggenBtn;
        private Label label1;
        private Label label2;
        private Label Benutzer;
        private Label Guthaben;
    }
}