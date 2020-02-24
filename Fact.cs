using System;


namespace Factorial
{
    class Program
    {
        static int  Factorial( int n)
        {
            if (n == 0 || n == 1)
            {
                 return 1;
            }
            else return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число для нахождения факториала: ");
            int iFactorial = int.Parse(Console.ReadLine());
            int iFactorialResult = Factorial(iFactorial);
            Console.WriteLine("{0}!={1}", iFactorial, iFactorialResult);
            Console.ReadKey();
        }
    }
}
