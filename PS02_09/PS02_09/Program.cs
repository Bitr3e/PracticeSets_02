using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_09
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter numbers separated by spaces: ");
            string input = Console.ReadLine();

            string[] stringNumbers = input.Split(' ');

            int[] numbers = Array.ConvertAll(stringNumbers, int.Parse);

            int sum = 0;

            int i = 0;

            while (i < numbers.Length)
            {
                sum += numbers[i];
                i++;
            }

            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}
