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
using Exercise_4.Theacher;

namespace Exercise_4.Theacher
{
    public partial class BankAppAddMoney : Form
    {
        BankApp app;
        //Number number;
        public BankAppAddMoney()
        {
           
            
            InitializeComponent();
        }

        public BankAppAddMoney(BankApp bankApp)
        {
            app = bankApp;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // BankDb.Instance.SomeNumber
               if( double.TryParse(textBox1.Text, out double result))
            {
                BankDb.Instance.SomeNumber = result;
            }
            else
            {
                textBox1.Text = "";
                errorProvider1.SetError(textBox1, "Not number");
            }
            
            //BankDb.Instance.SomeNumber = double.Parse(textBox1.Text,);
        }

        private void back_Click(object sender, EventArgs e)
        {
           // app.RefreshWork();
            app.RefreshWork();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        //bool ShowEditForm(int initialValue, out int newValue)
        //{
        //    this.textBox1.Text = textBox1.Text;
        //    if (this.ShowDialog() == DialogResult.OK)
        //    {
        //        newValue = int.Parse(textBox1.Text);
        //        return true;
        //    }

        //    newValue = 0;
        //    return false;
        //}
    }
}
