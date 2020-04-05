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

        static void Main(string[] args)
        {

            UserDrawCard();

            ComputerDrawCard();

            PrintWhoThisRound();

            CheckGameOver();

            PrintGameWinner();

            // create generator engine for random numbers (only once)
            // Random [name-i-give-to-engine] = new Random();
            Random rnd_generator = new Random(); // chinese -- only once

            int player_score = 0;
            int computer_score = 0;

            while (true)
            {
                int card_user = UserDrawCard(rnd_generator);

                // ----------------------------- computer draw card
                // computer pull random card + print card
                int computer_card = rnd_generator.Next(2, 15);
                if (computer_card < 11)
                {
                    Console.WriteLine($"Computer card : {computer_card}");
                }
                else if (computer_card == 11)
                {
                    Console.WriteLine("Computer card :J");
                }
                else if (computer_card == 12)
                {
                    Console.WriteLine("Computer card : Q");
                }
                else if (computer_card == 13)
                {
                    Console.WriteLine("Computer card : K");
                }
                else if (computer_card == 14)
                {
                    Console.WriteLine("Computer card : A");
                }

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

                // ----------------------------- print score
                Console.WriteLine($"Player score {player_score}");
                Console.WriteLine($"Computer score {computer_score}");
                Console.WriteLine("*********************************");
                Console.WriteLine();

                // ----------------------------- check game over
                if (Math.Abs(player_score - computer_score) >= 3)
                    break;

                // wait for readline
                Console.ReadLine();

            }
            // 2 3 4 5 6 7 8 9 10 J Q K A

            // --------------------------------- print winner
            if (player_score > computer_score)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Computer won!");
            }

            // wait for readline
            Console.ReadLine();

        }

        private static int UserDrawCard(Random rnd_generator)
        // function method 
        {
            // ----------------------------- user draw card
            // I pull random card + print card
            int card_user = rnd_generator.Next(2, 15);

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
                        Console.WriteLine("Player card :K");
                        break;
                }
            }

            return card_user;
        }
    }
}
