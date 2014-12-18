using Project;
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
    public partial class Form12 : Form
    {
        delegate void Back(int i);
        delegate void Choice(int i);

        string f;
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;
        int p6 = 0;
        int p7 = 0;
        int p8 = 0;
        int p9 = 0;
        int p10 = 0;
        int p11 = 0;
        int p12 = 0;

        public Form12()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;  
            
            pictureBox1.MouseClick += new MouseEventHandler(button_MouseClick);
            pictureBox2.MouseClick += new MouseEventHandler(button_MouseClick1);
            pictureBox3.MouseClick += new MouseEventHandler(button_MouseClick2);
            pictureBox4.MouseClick += new MouseEventHandler(button_MouseClick3);
            pictureBox5.MouseClick += new MouseEventHandler(button_MouseClick4);
            pictureBox6.MouseClick += new MouseEventHandler(button_MouseClick5);
            pictureBox7.MouseClick += new MouseEventHandler(button_MouseClick6);
            pictureBox8.MouseClick += new MouseEventHandler(button_MouseClick7);
            pictureBox9.MouseClick += new MouseEventHandler(button_MouseClick8);
            pictureBox10.MouseClick += new MouseEventHandler(button_MouseClick9);
            pictureBox11.MouseClick += new MouseEventHandler(button_MouseClick10);
            pictureBox12.MouseClick += new MouseEventHandler(button_MouseClick11);

            pictureBox1.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick);
            pictureBox2.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick1);
            pictureBox3.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick2);
            pictureBox4.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick3);
            pictureBox5.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick4);
            pictureBox6.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick5);
            pictureBox7.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick6);
            pictureBox8.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick7);
            pictureBox9.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick8);
            pictureBox10.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick9);
            pictureBox11.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick10);
            pictureBox12.MouseDoubleClick += new MouseEventHandler(button_MouseDoubleClick11);

            if ((pictureBox1.BackColor == null))
            {
                MessageBox.Show("Победа");
            }
        }

        public void Back1(int i)
        {
            if (i == 1)
            {
                pictureBox1.Enabled = true;
                pictureBox1.Show();
                pictureBox2.Enabled = true;
                pictureBox2.Show();
                pictureBox3.Enabled = true;
                pictureBox3.Show();
                pictureBox4.Enabled = true;
                pictureBox4.Show();
                pictureBox5.Enabled = true;
                pictureBox5.Show();
                pictureBox6.Enabled = true;
                pictureBox6.Show();
                pictureBox7.Enabled = true;
                pictureBox7.Show();

                button1.Enabled = false;
            }
            

            if (i == 2)
            {
                pictureBox1.Enabled = true;
                pictureBox1.Show();
                pictureBox2.Enabled = true;
                pictureBox2.Show();
                pictureBox3.Enabled = true;
                pictureBox3.Show();
                pictureBox8.Enabled = true;
                pictureBox8.Show();
                pictureBox9.Enabled = true;
                pictureBox9.Show();
                pictureBox10.Enabled = true;
                pictureBox10.Show();
                pictureBox11.Enabled = true;
                pictureBox11.Show();
                pictureBox12.Enabled = true;
                pictureBox12.Show();

                button1.Enabled = false;
            }

            if (i == 3)
            {
                pictureBox4.Enabled = true;
                pictureBox4.Show();
                pictureBox5.Enabled = true;
                pictureBox5.Show();
                pictureBox6.Enabled = true;
                pictureBox6.Show();
                pictureBox7.Enabled = true;
                pictureBox7.Show();
                pictureBox8.Enabled = true;
                pictureBox8.Show();
                pictureBox9.Enabled = true;
                pictureBox9.Show();
                pictureBox10.Enabled = true;
                pictureBox10.Show();
                pictureBox11.Enabled = true;
                pictureBox11.Show();
                pictureBox12.Enabled = true;
                pictureBox12.Show();

                button1.Enabled = false;
            }
        }

        

        public void Choice1(int i)
        {
            if (i == 1)
            {
                pictureBox4.Enabled = false;
                pictureBox4.Hide();
                pictureBox5.Enabled = false;
                pictureBox5.Hide();
                pictureBox6.Enabled = false;
                pictureBox6.Hide();
                pictureBox7.Enabled = false;
                pictureBox7.Hide();
                pictureBox8.Enabled = false;
                pictureBox8.Hide();
                pictureBox9.Enabled = false;
                pictureBox9.Hide();
                pictureBox10.Enabled = false;
                pictureBox10.Hide();
                pictureBox11.Enabled = false;
                pictureBox11.Hide();
                pictureBox12.Enabled = false;
                pictureBox12.Hide();

                button1.Enabled = true;
            }

            if (i == 2)
            {
                pictureBox1.Enabled = false;
                pictureBox1.Hide();
                pictureBox2.Enabled = false;
                pictureBox2.Hide();
                pictureBox3.Enabled = false;
                pictureBox3.Hide();
                pictureBox8.Enabled = false;
                pictureBox8.Hide();
                pictureBox9.Enabled = false;
                pictureBox9.Hide();
                pictureBox10.Enabled = false;
                pictureBox10.Hide();
                pictureBox11.Enabled = false;
                pictureBox11.Hide();
                pictureBox12.Enabled = false;
                pictureBox12.Hide();

                button1.Enabled = true;
            }

            if (i == 3)
            {
                pictureBox1.Enabled = false;
                pictureBox1.Hide();
                pictureBox2.Enabled = false;
                pictureBox2.Hide();
                pictureBox3.Enabled = false;
                pictureBox3.Hide();
                pictureBox4.Enabled = false;
                pictureBox4.Hide();
                pictureBox5.Enabled = false;
                pictureBox5.Hide();
                pictureBox6.Enabled = false;
                pictureBox6.Hide();
                pictureBox7.Enabled = false;
                pictureBox7.Hide();

                button1.Enabled = true;
            }
        }

        

        private void button_MouseDoubleClick11(object sender, MouseEventArgs e)
        {
            pictureBox12.BackColor = Color.LimeGreen;
            if (((pictureBox11.BackColor != Color.White) || (p11==1)) && ((pictureBox10.BackColor != Color.White) || (p10==1))
                && ((pictureBox9.BackColor != Color.White) || (p9 ==1)) && ((pictureBox8.BackColor != Color.White) || (p8==1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(1);
            }
        }

        private void button_MouseDoubleClick10(object sender, MouseEventArgs e)
        {
            pictureBox11.BackColor = Color.LimeGreen;
            if (((pictureBox12.BackColor != Color.White) || (p12==1)) && ((pictureBox10.BackColor != Color.White) || (p10==1))
                && ((pictureBox9.BackColor != Color.White) || (p9 ==1)) && ((pictureBox8.BackColor != Color.White) || (p8==1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(1);
            }
        }

        private void button_MouseDoubleClick9(object sender, MouseEventArgs e)
        {
            pictureBox10.BackColor = Color.LimeGreen;
             if (((pictureBox12.BackColor != Color.White) || (p12==1)) && ((pictureBox11.BackColor != Color.White) || (p11==1))
                 && ((pictureBox9.BackColor != Color.White) || (p9 ==1)) && ((pictureBox8.BackColor != Color.White) || (p8==1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(1);
            }
        }

        private void button_MouseDoubleClick8(object sender, MouseEventArgs e)
        {
            pictureBox9.BackColor = Color.LimeGreen;
            if (((pictureBox12.BackColor != Color.White) || (p12 == 1)) && ((pictureBox11.BackColor != Color.White) || (p11 == 1))
                && ((pictureBox10.BackColor != Color.White) || (p10 == 1)) && ((pictureBox8.BackColor != Color.White) || (p8 == 1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(1); 
            }
        }

        private void button_MouseDoubleClick7(object sender, MouseEventArgs e)
        {
            pictureBox8.BackColor = Color.LimeGreen;
            if ((pictureBox12.BackColor != Color.White) && (pictureBox11.BackColor != Color.White) && (pictureBox10.BackColor != Color.White)
                && (pictureBox9.BackColor != Color.White))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(1);
            }
        }

        private void button_MouseDoubleClick6(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.Lime;
            if (((pictureBox6.BackColor != Color.White) || (p6 ==1)) && ((pictureBox5.BackColor != Color.White) || (p5 == 1))
                && ((pictureBox4.BackColor != Color.White) || (p4 == 1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(2);
            }
        }

        private void button_MouseDoubleClick5(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.Lime;
            if (((pictureBox7.BackColor != Color.White) || (p7 == 1)) && ((pictureBox5.BackColor != Color.White) || (p5 == 1))
                && ((pictureBox4.BackColor != Color.White) || (p4 == 1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(2);
            }
        }

        private void button_MouseDoubleClick4(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.Lime;
            if (((pictureBox6.BackColor != Color.White) || (p6 == 1)) && ((pictureBox7.BackColor != Color.White) || (p7 == 1))
                && ((pictureBox4.BackColor != Color.White) || (p4 == 1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(2);
            }
        }

        private void button_MouseDoubleClick3(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.Lime;
            if (((pictureBox6.BackColor != Color.White) || (p6 == 1)) && ((pictureBox5.BackColor != Color.White) || (p5 == 1))
                && ((pictureBox7.BackColor != Color.White) || (p7 == 1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(2);
            }
        }

        private void button_MouseDoubleClick2(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.GreenYellow;
            if (((pictureBox2.BackColor != Color.White) || (p2 ==1)) && ((pictureBox1.BackColor != Color.White) || (p1==1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(3);
            }
        }

        private void button_MouseDoubleClick1(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.GreenYellow;
            if (((pictureBox3.BackColor != Color.White) || (p3 == 1)) && ((pictureBox1.BackColor != Color.White) || (p1 == 1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(3);
            }
        }

        private void button_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.GreenYellow;
            if (((pictureBox2.BackColor != Color.White) || (p2 == 1)) && ((pictureBox3.BackColor != Color.White) || (p3 == 1)))
            {
                Back bk = new Back(Back1);
                bk = Back1;
                bk(3);
            }
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(1);
        }

        private void button_MouseClick1(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(1);
        }
        private void button_MouseClick2(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(1);
        }
        private void button_MouseClick3(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(2);
        }
        private void button_MouseClick4(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(2);
        }
        private void button_MouseClick5(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(2);
        }
        private void button_MouseClick6(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(2);
        }
        private void button_MouseClick7(object sender, MouseEventArgs e)
        {
            pictureBox8.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(3);
        }
        private void button_MouseClick8(object sender, MouseEventArgs e)
        {
            pictureBox9.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(3);
        }
        private void button_MouseClick9(object sender, MouseEventArgs e)
        {
            pictureBox10.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(3);
        }
        private void button_MouseClick10(object sender, MouseEventArgs e)
        {
            pictureBox11.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(3);
        }
        private void button_MouseClick11(object sender, MouseEventArgs e)
        {
            pictureBox12.BackColor = Color.White;
            Choice ch = new Choice(Choice1);
            ch = Choice1;
            ch(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.BackColor = Color.Blue;
                Controls.Remove(pictureBox1);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p1++;
            }

            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.BackColor = Color.Blue;
                Controls.Remove(pictureBox2);
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p2++;
            }

            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.BackColor = Color.Blue;
                Controls.Remove(pictureBox3);
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p3++;
            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.BackColor = Color.Blue;
                Controls.Remove(pictureBox4);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p4++;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.BackColor = Color.Blue;
                Controls.Remove(pictureBox5);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p5++;
            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.BackColor = Color.Blue;
                Controls.Remove(pictureBox6);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p6++;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.BackColor = Color.Blue;
                Controls.Remove(pictureBox7);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p7++;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.BackColor = Color.Blue;
                Controls.Remove(pictureBox8);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p8++;
            }

            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.BackColor = Color.Blue;
                Controls.Remove(pictureBox9);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p9++;
            }

            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.BackColor = Color.Blue;
                Controls.Remove(pictureBox10);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p10++;
            }

            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.BackColor = Color.Blue;
                Controls.Remove(pictureBox11);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                pictureBox12.Show();
                pictureBox12.Enabled = true;
                p11++;
            }

            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.BackColor = Color.Blue;
                Controls.Remove(pictureBox12);
                pictureBox2.Show();
                pictureBox2.Enabled = true;
                pictureBox3.Show();
                pictureBox3.Enabled = true;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
                pictureBox5.Show();
                pictureBox5.Enabled = true;
                pictureBox6.Show();
                pictureBox6.Enabled = true;
                pictureBox7.Show();
                pictureBox7.Enabled = true;
                pictureBox8.Show();
                pictureBox8.Enabled = true;
                pictureBox9.Show();
                pictureBox9.Enabled = true;
                pictureBox10.Show();
                pictureBox10.Enabled = true;
                pictureBox11.Show();
                pictureBox11.Enabled = true;
                pictureBox1.Show();
                pictureBox1.Enabled = true;
                p12++;
            }           
            Change();
           }

        public void Change()
        {
            if ((p1 == 1) && (p2 == 1) && (p3 == 1) && (p4 == 1) && (p5 == 1) && (p6 == 1) &&
                (p7 == 1) && (p8 == 1) && (p9 == 1) && (p10 == 1) && (p11 == 1) && (p12 == 1))
            {
                MessageBox.Show("Выиграл " + label2.Text);
                f = label2.Text;
                Form5 f1 = new Form5();
                f1.Show();
                this.Close();               
            }
                
            string s = label1.Text;
            label1.Text = label2.Text;
            label2.Text = s;

            if (f == "Первый игрок")
            {                                           
                string text = "Первый игрок победил!";
                System.IO.File.WriteAllText(@"D:\WriteLines.txt", text);
            }
            else if (f == "Второй игрок")
            {
                string text = "Второй игрок победил!";
                System.IO.File.WriteAllText(@"D:\WriteLines.txt", text);
            }                   
        }

        private void button2_Click(object sender, EventArgs e)
        {            
                string text = System.IO.File.ReadAllText(@"D:\WriteLines.txt");
                MessageBox.Show("Последний результат:" +" "+ text);           
        }

        private void закрытьПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Show();
            this.Close();
        }      
    }
}
