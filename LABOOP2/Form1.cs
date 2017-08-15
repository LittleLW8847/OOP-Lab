using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABOOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += Button0.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = Button0.Text;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = button3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button7.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button1.Text;
                }
            }
            
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button2.Text;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button3.Text;
                }
            }
        }
     /*   private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }*/

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button5.Text;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button6.Text;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button8.Text;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button9.Text;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                {
                    textBox1.Text = button4.Text;
                }
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = button12.Text;
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            textBox1.Text = buttondivide.Text;
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text = buttonmultiply.Text;
        }

    }


}
