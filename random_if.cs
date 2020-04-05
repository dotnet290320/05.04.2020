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
 
            // use must enter a number between 10-1000
            int number = 0;
            do
            {
                Console.WriteLine("Please enter range (10-1000):"); // 1a
            }
            while (int.TryParse(Console.ReadLine(), out number) == false || number < 10 || number > 1000);

            // number was parsed successfully
            // number is between 10-1000

            // if ( A && B && C )
            //    if A is true then check B
            //    if B is true then check C
            //    if C is true then return --> true
            //    -- because false and ANYTHING = false
            //
            // if ( A || B || C )
            //   if A is true then return --> true
            //   if A is false then check B. if B is true then return --> true
            //   if A is false and B is false then check C. if c is true then return --> true
            //   -- because true or ANYTHING = true

            // legal -- parse succeed , number >=10 and number <= 1000
            // while:
            // parse failed, or number < 10, or number > 1000


            // for user input = 100
            // user will get a random number between 1-100
            Random random_engine = new Random(); // chinese -- only once !
            int random_number = random_engine.Next(1, number + 1);

            Console.WriteLine($"the generated random number is {random_number}");




        }
    }
}
