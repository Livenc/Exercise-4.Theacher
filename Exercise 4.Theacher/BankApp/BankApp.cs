using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4.Theacher
{
    public partial class BankApp : Form
    {

      
        public BankApp()
        {
            InitializeComponent();
           
        }

        private void BankApp_Load(object sender, EventArgs e)
        {
            label1.Text = BankDb.Instance.SomeNumber.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankAppAddMoney bankAppMoney = new BankAppAddMoney(this);
            bankAppMoney.ShowDialog();
            bankAppMoney = null;
         
            this.Show();
            
        }
        public void RefreshWork()
        {
            label1.Text = BankDb.Instance.SomeNumber.ToString();
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
          // label1.Text = money.ToString();
        }

        private void bTransfer_Click(object sender, EventArgs e)
        {
            //label1.Text = Number.Instance.SomeNumber.ToString() ;
            
        }

        
    }
}
