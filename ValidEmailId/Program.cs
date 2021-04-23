using System;

namespace ValidEmailId
{
    class Program
    {
        static void Main(string[] args)
        {
            Emailpattern input = new Emailpattern();

            Console.WriteLine("Enter your Email Id:");
            bool result = input.validateEmail(Console.ReadLine());
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
