﻿using System;
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
    public partial class PopUpAbheben : Form
    {
        public PopUpAbheben()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            var Hauptseite = new Hauptseite();
            Hauptseite.Show();
            this.Close();
        }
    }
}
