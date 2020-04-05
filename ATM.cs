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
                Console.WriteLine("Please enter sum for ATM withdraw:");
            }
            while (int.TryParse(Console.ReadLine(), out number) == false);

            // 200 100 20 5
            // 450

            // 200
            if (number >= 200)
            {
                // give 200 bills
                int bills200 = number / 200;
                Console.WriteLine($"{bills200} x 200");

                // 450 - 400 = 50
                // correct
                //number = number - (number / 200) * 200;

                // 450 % 200 = 50
                // 450 / 200 = 2 50/200
                number = number % 200;
            }

            // 100
            if (number >= 100)
            {
                // give 100 bills
                int bills100 = number / 100;
                Console.WriteLine($"{bills100} x 100");

                number = number % 100;
            }

            // 20
            if (number >= 20)
            {
                // give 20 bills
                int bills20 = number / 20;
                Console.WriteLine($"{bills20} x 20");

                number = number % 20;
            }

            // 5
            if (number >= 5)
            {
                // give 100 bills
                int coins5 = number / 5;
                Console.WriteLine($"{coins5} coins x 5");

                number = number % 5;
            }

            if (number > 0)
            {
                Console.WriteLine($"{number} shekels");
            }
        }
    }
}
