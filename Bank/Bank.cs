using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        int totalSavings;
        private int accountBalance
        { get; set; }

        public int Deposit(int amountDeposited, int numberWeeks)
        {
        totalSavings = amountDeposited * numberWeeks;
        accountBalance = accountBalance + totalSavings;
        return totalSavings;
        }
        public void Withdraw(int amountWithdrawn)
        {
            accountBalance = accountBalance - amountWithdrawn;
        }

        public int ShowBalance()
        {
            return accountBalance;
        }
    }
}
