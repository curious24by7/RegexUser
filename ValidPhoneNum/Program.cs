using System;

namespace ValidPhoneNum
{
    class Program
    {
        static void Main(string[] args)
        {
            phonePattern input = new phonePattern();

            Console.WriteLine("Enter your Phone Number with country code (91) :");
            bool result = input.validatePhoneNumber(Console.ReadLine());
            Console.WriteLine(result);

            while (result != true)
            {
                Console.WriteLine("Enter your Phone Number with country code (91) :");

                phonePattern secondinput = new phonePattern();

                bool scndresult = secondinput.validatePhoneNumber(Console.ReadLine());
                Console.WriteLine(scndresult);

            }
            Console.ReadKey();
        }
    }
}
