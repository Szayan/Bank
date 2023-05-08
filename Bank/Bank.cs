using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // Bank class
    internal class Bank
    {
        // Field to store total savings after deposit is made
        int totalSavings;
        
        // Property to get/set account balance
        private int accountBalance { get; set; }

        // Method to deposit amount for specified number of weeks and return total savings
        public int Deposit(int amountDeposited, int numberWeeks)
        {
            // Calculate total savings
            totalSavings = amountDeposited * numberWeeks;
            // Add total savings to account balance
            accountBalance = accountBalance + totalSavings;
            // Return total savings
            return totalSavings;
        }

        // Method to withdraw specified amount from account balance
        public void Withdraw(int amountWithdrawn)
        {
            // Subtract amount withdrawn from account balance
            accountBalance = accountBalance - amountWithdrawn;
        }

        // Method to show current account balance
        public int ShowBalance()
        {
            // Return account balance
            return accountBalance;
        }
    }
}