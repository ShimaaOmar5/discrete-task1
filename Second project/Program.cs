using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int Num2 = int.Parse(Console.ReadLine());
            int i, n, sum;
            for (n = Num1; n <= Num2; n++)
            {
                sum = 0;
                for (i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
