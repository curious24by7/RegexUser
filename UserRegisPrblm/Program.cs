﻿using System;

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
            Console.ReadKey();
        }
    }
}