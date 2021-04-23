using System;

namespace ValidatePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordPattern input = new PasswordPattern();

            Console.WriteLine("Enter your Password:");
            bool result = input.validatePassword(Console.ReadLine());
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
