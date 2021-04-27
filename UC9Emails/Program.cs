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

            while (result != true)
            {
                Console.WriteLine("Enter Email Id :");

                RegexPattern secondinput = new RegexPattern();

                bool scndresult = secondinput.validateEmail(Console.ReadLine());
                Console.WriteLine(scndresult);

                if (scndresult == true)

                    break;

            }

            Console.ReadKey();

        }
    }
}
