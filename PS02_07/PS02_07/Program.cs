using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            int[] frequency = new int[256]; 

            int i = 0;

            while (i < inputString.Length)
            {
                frequency[inputString[i]]++;
                i++;
            }

            i = 0;

            while (i < 256)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine($"'{(char)i}': {frequency[i]}");
                }
                i++;
            }

        }
    }
}
