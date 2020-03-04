﻿using System;

    namespace Factorial
    {
        class Program
        {
            static int Factorial(int n)
            {
                if (n < 0)
                return 00;
                if (n == 0 || n == 1)
                {
                    return 1;
                    
                }
                else return n * Factorial(n - 1);

            }

            static void Main(string[] args)
            {
                Console.Write("Введите число для нахождения факториала:");
                int n = int.Parse(Console.ReadLine());
                int iFactorialResult = Factorial(n);
                Console.WriteLine("{0}!={1}", n, iFactorialResult);
                Console.ReadKey();

            }

        }
    }
