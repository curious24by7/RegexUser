using System;

namespace UC9Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexPattern input = new RegexPattern();

            Console.WriteLine("Enter Email Id :");
            bool result = input.validateEmail(Console.ReadLine());
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
