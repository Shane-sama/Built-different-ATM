namespace Built_different_ATM
{
    partial class PopUpAbheben
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
            this.abgehobenLabel = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abgehobenLabel
            // 
            this.abgehobenLabel.AutoSize = true;
            this.abgehobenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abgehobenLabel.Location = new System.Drawing.Point(236, 108);
            this.abgehobenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.abgehobenLabel.Name = "abgehobenLabel";
            this.abgehobenLabel.Size = new System.Drawing.Size(432, 38);
            this.abgehobenLabel.TabIndex = 0;
            this.abgehobenLabel.Text = "Ihr Geld wurde ausgezahlt.\r\n";
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.OKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OKBtn.Location = new System.Drawing.Point(409, 341);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(118, 65);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // PopUpAbheben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(978, 566);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.abgehobenLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PopUpAbheben";
            this.Text = "PopUpAbheben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label abgehobenLabel;
        private Button OKBtn;
    }
}