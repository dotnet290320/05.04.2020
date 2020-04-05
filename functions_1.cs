using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0504
{
    class Program
    {
        // function -- method
        // 1. logic - seperate of concern -- chore
        // 2. avoid code repittion
        // 3. expose code to other "programs"
        // 4. Main -- program "story"

        // void = nothing
        
        // static - chinese
        // void - what will the function returns

        /// <summary>
        /// print hello from foo
        /// </summary>
        static void PrintHello() // Pascal case
        {
            Console.WriteLine("hello from Foo!");
        }

        /// <summary>
        /// Readline number from user until legal number is inserted
        /// </summary>
        /// <returns>int value parsed from user input</returns>
        static int InputNumberFromUser()
        {
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a number:");
            }
            while (int.TryParse(Console.ReadLine(), out number) == false);

            return number;
        }

        /// <summary>
        /// Presents a menu with 4 options: 
        /// (1) add (2) subtract (3) multiply (4) divide
        /// user input until legal
        /// </summary>
        /// <returns></returns>
        static int GetUserCalcOption()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Please enter an option:");
                Console.WriteLine("1. add");
                Console.WriteLine("2. minus");
                Console.WriteLine("3. multiply");
                Console.WriteLine("4. divide");
            }
            while (int.TryParse(Console.ReadLine(), out option) == false || option < 1 || option > 4);
            // in range 1-4
            // read numbers while:
            // number cannot parse , number < 1 , number > 4

            return option;
        }


        /// <summary>
        /// Print calculator result of operation, for (1) add (2) subtract (3) multiply (4) divide
        /// </summary>
        /// <param name="option">user selection</param>
        /// <param name="first_number">a</param>
        /// <param name="second_number">b</param>
        static void PrintCalculation(int option, int first_number, int second_number)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine($"{first_number} + {second_number} = {first_number + second_number}");
                    break;
                case 2:
                    Console.WriteLine($"{first_number} - {second_number} = {first_number - second_number}");
                    break;
                case 3:
                    Console.WriteLine($"{first_number} * {second_number} = {first_number * second_number}");
                    break;
                case 4:
                    Console.WriteLine($"{first_number} / {second_number} = {first_number / Convert.ToDouble(second_number)}");
                    break;
            }
            option++;
        }

        static int Main(string[] args)
        {
            Console.WriteLine("Calculator:");
            int a = InputNumberFromUser();
            int b = InputNumberFromUser();
            int opt = GetUserCalcOption();
            PrintCalculation(opt, a, b);

            // out of switch-case

            //Console.WriteLine($"{a} + {b} = {a+b}");


            //Console.ReadLine();
            //PrintHello();
            //PrintHello();
            //PrintHello();

            int z = 1;
            return z;
        }
    }
}
