﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class FormPisteTaulukko : Form
    {
        public FormPisteTaulukko()
        {
            InitializeComponent();
        }

        private void FormPisteTaulukko_Load(object sender, EventArgs e)
        {
            rtb_Pistetaulukko.Text = File.ReadAllText("Pistetaulukko.txt");
        }
    }
}
