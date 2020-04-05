using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0504
{
    class Program
    {

        private static int UserDrawCard(int card_user)
        // function method 
        {
            // ----------------------------- user draw card
            // I pull random card + print card


            if (card_user < 11)
            {
                Console.WriteLine($"Player card : {card_user}");
            }
            else
            {
                switch (card_user)
                {
                    case 11:
                        Console.WriteLine("Player card :J");
                        break;
                    case 12:
                        Console.WriteLine("Player card :Q");
                        break;
                    case 13:
                        Console.WriteLine("Player card :K");
                        break;
                    default: // else
                        Console.WriteLine("Player card :");
                        break;
                }
            }

            return card_user;
        }

        private static void ComputerDrawCard(int computer_card)
        {
            // ----------------------------- computer draw card
            // computer pull random card + print card

            if (computer_card < 11)
            {
                Console.WriteLine($"Computer card : {computer_card}");
            }
            else
            {
                switch (computer_card)
                {
                    case 11:
                        Console.WriteLine("Computer card :J");
                        break;
                    case 12:
                        Console.WriteLine("Computer card :Q");
                        break;
                    case 13:
                        Console.WriteLine("Computer card :K");
                        break;
                    default: // else
                        Console.WriteLine("Computer card :A");
                        break;
                }
            }
        }

        static void PrintResultAndCalcScore(int card_user, int computer_card, ref int player_score, ref int computer_score)
        {
            // ----------------------------- print who won this round
            if (card_user == computer_card)
            {
                Console.WriteLine("Draw ....");
            }
            else if (card_user > computer_card)
            {
                player_score++;
                Console.WriteLine("Player won!");
            }
            else
            {
                computer_score++;
                Console.WriteLine("Computer won!");
            }
        }

        private static void PrintScore(int player_score, int computer_score)
        {
            // ----------------------------- print score
            Console.WriteLine($"Player score {player_score}");
            Console.WriteLine($"Computer score {computer_score}");
            Console.WriteLine("*********************************");
            Console.WriteLine();
        }

        private static void PrintFinalScore(int player_score, int computer_score)
        {
            // --------------------------------- print winner
            if (player_score > computer_score)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Computer won!");
            }
        }

        // function -- method
        // 1. logic - seperate of concern -- chore
        // 2. avoid code repittion
        // 3. expose code to other "programs"
        // 4. Main -- program "story"

        static void Main(string[] args)
        {
            Random random_generator = new Random();
            Random rnd_generator = new Random(); // chinese -- only once

            int player_score = 0;
            int computer_score = 0;

            while (true)
            {
                int card_user = random_generator.Next(2, 15);
                UserDrawCard(card_user);

                int computer_card = rnd_generator.Next(2, 15);
                ComputerDrawCard(computer_card);

                PrintResultAndCalcScore(card_user, computer_card, ref player_score, ref computer_score);
                PrintScore(player_score, computer_score);

                // ----------------------------- check game over
                if (Math.Abs(player_score - computer_score) >= 3)
                    break;

                // wait for readline
                Console.ReadLine();

            }
            // 2 3 4 5 6 7 8 9 10 J Q K A

            PrintFinalScore(player_score, computer_score);

            // wait for readline
            Console.ReadLine();
        }


    }
}
