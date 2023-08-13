using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorMult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int factor = 2;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= factor;
            }

            Console.WriteLine("Multiplied array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
