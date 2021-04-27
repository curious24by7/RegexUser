using System;

namespace UserRegisPrblm
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstNamePattern input = new FirstNamePattern();

            Console.WriteLine("Enter First Name :");
            bool result = input.validateName(Console.ReadLine());
            Console.WriteLine(result);

            while (result != true)
            {
                Console.WriteLine("Enter Firt Name :");

                FirstNamePattern secondinput = new FirstNamePattern();

                bool scndresult = secondinput.validateName(Console.ReadLine());
                Console.WriteLine(scndresult);

                if (scndresult == true)

                    break;

            }
            Console.ReadKey();
        }
    }
}
