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
    public partial class BankApp : Form
    {

        public int money=0;
       
        public BankApp()
        {
            InitializeComponent();
           
        }

        private void BankApp_Load(object sender, EventArgs e)
        {
            label1.Text = money.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankAppAddMoney bankAppMoney = new BankAppAddMoney();
            bankAppMoney.ShowDialog();
            bankAppMoney = null;
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          // label1.Text = money.ToString();
        }

        private void bTransfer_Click(object sender, EventArgs e)
        {
            label1.Text = money.ToString();
        }
    }
}
