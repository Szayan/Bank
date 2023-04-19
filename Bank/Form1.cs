using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bank bank = new Bank();
        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            //txtDeposit.Text
            total = bank.Deposit(Convert.ToInt32(Deposittxt.Text) , Convert.ToInt32(WeeksTxt.Text));
            Balance.Text = total.ToString();
            NewBalance.Text = Convert.ToString(bank.ShowBalance()) + " kr";
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            bank.Withdraw(Convert.ToInt32(Wallet.Text));
            NewBalance.Text = Convert.ToString(bank.ShowBalance()) + " kr";
            Wallet.Text = "";

        }
    }
}
