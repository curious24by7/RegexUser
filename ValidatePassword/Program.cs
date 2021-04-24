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

            while (result != true)
            {
                Console.WriteLine("Enter your Password :");

                PasswordPattern secondinput = new PasswordPattern();

                bool scndresult = secondinput.validatePassword(Console.ReadLine());
                Console.WriteLine(scndresult);

            }
            Console.ReadKey();
        }
    }
}
