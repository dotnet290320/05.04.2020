using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0504
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int number = 0;
            do
            {
                Console.WriteLine("Please enter number of lines:");
            }
            while (int.TryParse(Console.ReadLine(), out number) == false);

            Console.WriteLine();

            // 1
            // 12
            // 123
            // 1234
            for (int line_number = 1; line_number <= number; line_number++)
            {
                for (int row = 1; row <= line_number; row++)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }

            // 123
            // 12
            // 1
            for (int line_number = number - 1; line_number >= 1; line_number--)
            {
                for (int row = 1; row <= line_number; row++)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }

        }
    }
}
