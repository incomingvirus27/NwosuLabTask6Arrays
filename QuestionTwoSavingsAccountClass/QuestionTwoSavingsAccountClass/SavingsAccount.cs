using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionTwoSavingsAccountClass
{
    class SavingsAccount
    {
        private static decimal annualInterestRate = 0.04m;
        private decimal savingsBalance;

        public SavingsAccount(decimal currentBalance)
        {
            SavingsBalance = currentBalance;
        }
        public decimal SavingsBalance
        {
            get { return savingsBalance; }
            set
            {
                savingsBalance = value + CalculateMonthlyInterest(value);
            }
        }
        public decimal CalculateMonthlyInterest(decimal value)
        {
            return value * (annualInterestRate / 12);
        }
        public static void ModifyInterest(decimal rate)
        {
            annualInterestRate = rate / 100;
        }
        public override string ToString()
        {
            return string.Format("Savings account with monthly interest is {0:c}", SavingsBalance);
        }




    }
}
