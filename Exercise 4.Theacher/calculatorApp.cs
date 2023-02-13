using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4.Theacher
{
    public partial class calculatorApp : Form
    {
        public calculatorApp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();

        void CheckArif(string i)
        {
            if(textBox1.Text!= "") {
                if (textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-' || textBox1.Text[textBox1.Text.Length - 1] == '*' || textBox1.Text[textBox1.Text.Length - 1] == '/'|| textBox1.Text[textBox1.Text.Length - 1] == '.')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1) + i;
                }
                else
                {
                    textBox1.Text += i;
                }
            }
            
        }
        private void bDiv_Click(object sender, EventArgs e)
        {
            //string init = Convert.ToString(textBox1.Text[textBox1.Text.Length - 1]);
            //MessageBox.Show(textBox1.Text[textBox1.Text.Length - 1]);
            //if (textBox1.Text[textBox1.Text.Length - 1] == '+' || textBox1.Text[textBox1.Text.Length - 1] == '-' || textBox1.Text[textBox1.Text.Length - 1] == '*'|| textBox1.Text[textBox1.Text.Length - 1] == '/')
            //{
            //    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1) + "/";
            //}
            //else
            //{
            //    textBox1.Text += bDiv.Text;
            //}
            CheckArif(bDiv.Text);

        }

        private void bMul_Click(object sender, EventArgs e)
        {
            CheckArif(bMul.Text);
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            CheckArif(BAdd.Text);
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            CheckArif(bSub.Text);
        }

        private void bPi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3.14";
        }

        private void bE_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2.71";
        }

        private void bDell_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void bDellOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text += b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += b9.Text;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text += b0.Text;
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            CheckArif(bDot.Text);
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length-1] == '+' || textBox1.Text[textBox1.Text.Length-1] == '-' || textBox1.Text[textBox1.Text.Length-1] == '*' || textBox1.Text[textBox1.Text.Length-1] == '/')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else
            {
                var v = dt.Compute(textBox1.Text, "");
                textBox1.Text = Convert.ToString(v);
            }
           
        }

        private void calculatorApp_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
