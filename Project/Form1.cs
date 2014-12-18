using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В данной версии режим игры с компьютером не доступен. Данный режим ожидается в ближайшем обновлении.");
            //Form8 р = new Form8();
            //р.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 r = new Form2();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
            this.Hide();
        }

        private void закрытьПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 b = new Form7();
            b.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
