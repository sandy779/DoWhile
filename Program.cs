using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, fact = 1, n;
            Console.WriteLine("Enter limit");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                fact = fact * i;
                Console.WriteLine("Factorial of {0} is {1}", i, fact);
                i++;
                
            } while (i <= n);
        }
    }
}
