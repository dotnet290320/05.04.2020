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

            // 4 lines
            //    *
            //   ***
            //  *****
            // *******
            int stars = 1;
            int spaces = number - 1;
            for (int line_number = 1; line_number <= number; line_number++)
            {
                // spaces
                for (int row = 1; row <= spaces; row++)
                {
                    Console.Write(' ');
                }

                // stars *
                for (int row = 1; row <= stars; row++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

                stars = stars + 2;
                spaces--;
            }

          

        }
    }
}
