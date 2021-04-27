using System;

namespace ValidLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            LastNamePattern input = new LastNamePattern();

            Console.WriteLine("Enter Last Name :");
            bool result = input.validateName(Console.ReadLine());
            Console.WriteLine(result);

            while (result != true)
            {
                Console.WriteLine("Enter Last Name :");

                LastNamePattern secondinput = new LastNamePattern();

                bool scndresult = secondinput.validateName(Console.ReadLine());
                Console.WriteLine(scndresult);

                if (scndresult == true)

                    break;

            }
            Console.ReadKey();
        }
    }
}
