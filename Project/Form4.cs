﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void закрытьПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Show();
            this.Close();
        }
    }
}
