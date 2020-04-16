using System;

namespace QuestionThreeComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(2.0f, 3.0f);
            Complex num2 = new Complex(3.5f, 4.2f);

            Complex add = num1 + num2;
            Complex sub = num1 - num2;

            Console.WriteLine("First Complex Number :  {0}", num1);
            Console.WriteLine("Second Complex Number : {0}", num2);

            Console.WriteLine($"The addition of the two complex numbers is: {add} ");
            Console.WriteLine($"The subtraction of the two complex numbers is: {sub} ");
            Console.ReadLine();           
        }
    }
}
