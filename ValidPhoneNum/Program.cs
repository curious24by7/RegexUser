using System;

namespace ValidPhoneNum
{
    class Program
    {
        static void Main(string[] args)
        {
            phonePattern input = new phonePattern();

            Console.WriteLine("Enter your Phone Number:");
            bool result = input.validatePhoneNumber(Console.ReadLine());
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
