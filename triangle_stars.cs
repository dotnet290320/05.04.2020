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

            // 1**** - line 1 -- 5-1 = 4 *
            // 12*** - line 2 -- 5-2 = 3 *
            // 123** - line 3 -- 5-3 = 2 *
            // 1234* - line 4 -- 5-4 = 1 *
            // 12345 - line 5 -- 5-5 = 0 *
            for (int line_number = 1; line_number <= number; line_number++)
            {
                for (int row = 1; row <= line_number; row++)
                {
                    Console.Write(row);
                }
                for (int row = 1; row <= number - line_number; row++)
                {
                    Console.Write('*');
                }

                // shorter (difiicult?)
                /*
                for (int row = 1; row <= number; row++)
                {
                    if (row <= line_number)
                        Console.Write(row);
                    else
                        Console.Write('*');
                }
                */
                Console.WriteLine();
            }
            
        }
    }
}
