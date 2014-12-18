using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void закрытьПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 р = new Form4();
            р.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 р = new Form3();
            р.Show();
            this.Close();
        }
    }
}
