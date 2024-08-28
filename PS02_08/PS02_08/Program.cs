using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {

                int digit = input[i] - '0';

                sum += digit;
            }

            Console.WriteLine($"The sum of the digits is: {sum}");

        }
    }
}
