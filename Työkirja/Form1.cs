﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Työkirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string nimi = "";
        public string yritys = "";

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            nimi = txtNimi.Text;
            yritys = txtYritys.Text;
        }
    }
}
