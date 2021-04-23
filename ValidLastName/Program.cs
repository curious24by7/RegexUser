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
            Console.ReadKey();
        }
    }
}
