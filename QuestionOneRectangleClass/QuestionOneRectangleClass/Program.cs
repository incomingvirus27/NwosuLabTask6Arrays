using System;

namespace QuestionOneRectangleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(19.5f, 3.4f);
            Rectangle rectangle2 = new Rectangle(-1.0f, 21.03f);
            Console.WriteLine($"For numbers within the range of 0 and 20,{rectangle}");
            Console.WriteLine($"For numbers outside the range of 0 and 20,{rectangle2}");           
        }
    }
}
