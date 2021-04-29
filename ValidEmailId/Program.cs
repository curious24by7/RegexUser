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

            while (result != true)
            {
                Console.WriteLine("Enter Email Id :");

                Emailpattern secondinput = new Emailpattern();

                bool scndresult = secondinput.validateEmail(Console.ReadLine());
                Console.WriteLine(scndresult);

                if (scndresult == true)

                    break;

            }
            Console.ReadKey();
        }
    }
