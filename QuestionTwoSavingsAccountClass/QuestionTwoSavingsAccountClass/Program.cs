using System;

namespace QuestionTwoSavingsAccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount saver1 = new SavingsAccount(2000);
            SavingsAccount saver2 = new SavingsAccount(3000);

            Console.WriteLine(saver1);
            Console.WriteLine(saver2);
            Console.WriteLine("................................");
            Console.WriteLine("Account with 5% interest");

            SavingsAccount.ModifyInterest(5);
            saver1.SavingsBalance = 2000;
            saver2.SavingsBalance = 3000;

            Console.WriteLine(saver1);
            Console.WriteLine(saver2);

        }
    }
}
