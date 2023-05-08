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
        // Create an instance of the Bank class
        Bank bank = new Bank();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            // Convert the input values to integers and pass them to the Deposit method of the Bank class
            total = bank.Deposit(Convert.ToInt32(Deposittxt.Text), Convert.ToInt32(WeeksTxt.Text));
            // Update the balance label with the total savings
            Balance.Text = total.ToString();
            // Update the new balance label with the current account balance
            NewBalance.Text = Convert.ToString(bank.ShowBalance()) + " kr";
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            // Convert the input value to an integer and pass it to the Withdraw method of the Bank class
            bank.Withdraw(Convert.ToInt32(Wallet.Text));
            // Update the new balance label with the current account balance
            NewBalance.Text = Convert.ToString(bank.ShowBalance()) + " kr";
            // Clear the input field for the withdrawal amount
            Wallet.Text = "";
        }
    }
}