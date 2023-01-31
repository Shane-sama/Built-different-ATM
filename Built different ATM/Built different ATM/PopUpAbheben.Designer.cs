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
            this.abgehobenLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abgehobenLabel.Location = new System.Drawing.Point(189, 86);
            this.abgehobenLabel.Name = "abgehobenLabel";
            this.abgehobenLabel.Size = new System.Drawing.Size(397, 99);
            this.abgehobenLabel.TabIndex = 0;
            this.abgehobenLabel.Text = "Sie haben x Franken \r\nabgehoben. Ihr Guthaben \r\nbeträgt noch y Franken.";
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.OKBtn.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OKBtn.Location = new System.Drawing.Point(327, 273);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(94, 52);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            // 
            // PopUpAbheben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.abgehobenLabel);
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