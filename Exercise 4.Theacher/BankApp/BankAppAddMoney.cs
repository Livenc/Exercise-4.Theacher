using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4.Theacher
{
    public partial class BankAppAddMoney : Form
    {

        BankApp bank;
        public BankAppAddMoney()
        {
           
            
            InitializeComponent();
        }
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            ShowEditForm(13, out bank.money);
            string iju = textBox1.Text;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool ShowEditForm(int initialValue, out int newValue)
        {
            this.textBox1.Text = textBox1.Text;
            if (this.ShowDialog() == DialogResult.OK)
            {
                newValue = int.Parse(textBox1.Text);
                return true;
            }

            newValue = 0;
            return false;
        }
    }
}
