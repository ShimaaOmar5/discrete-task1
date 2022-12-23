using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Mathematics_practical_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num, i, counter, num1, num2;

            Console.Write("Please enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are : ", num1, num2);

            for (num = num1; num <= num2; num++)
            {
                counter = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter== 0 && num != 1)
                    Console.Write("{0} ", num);

            }
            Console.ReadKey();






        }
    }
}
