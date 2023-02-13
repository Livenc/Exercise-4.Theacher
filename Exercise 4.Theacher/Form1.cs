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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = dateTime.ToString("HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameXandO gameXandO = new GameXandO();
            gameXandO.ShowDialog();
            gameXandO = null;
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenIA openIA = new OpenIA();
            openIA.ShowDialog();
            openIA = null;
            this.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            calculatorApp calcApp = new calculatorApp();
            calcApp.ShowDialog();
            calcApp = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankApp bankApp = new BankApp();
            bankApp.ShowDialog();
            bankApp = null;
            this.Show();
        }
    }
}
