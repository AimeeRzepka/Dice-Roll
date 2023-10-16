using System.Net.NetworkInformation;
using System.Threading.Channels;

namespace Random_Dice_Roll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine("How many sides should each die have?");
            int diceSides = int.Parse(Console.ReadLine());
            Console.WriteLine("LET'S ROLL!!!!!");

            int x = 1;
            int y = diceSides; // so we can be inclusive of the dice # in our rolls
            static int generateRolls(int x, int y) // THIS IS THE FUNCTION TO GENERATE A RANDOM NUMBER//

            {
                Random random = new Random();
                int randomRollX = random.Next(x, y);
                return randomRollX;
            }

            static string returnCombos(int x, int y)
            {
                if (x == 1 && y == 1)
                    {
                    return "SNAKE EYES! Two 1s";
                    }
                else if ((x == 2 && y ==1) || (x == 1 && y == 2))
                {
                    return "ACE DUECE! A 1 and a 2";
                }
                else if (x == 6 && y == 6 )
                {
                    return "BOX CARS! TWO 6s";
                }
                return "";
            }

            static string returnTotals(int x, int y)
            {
                int totalRoll = x + y;
                if (totalRoll == 7 || totalRoll == 11)
                {
                    return "WIN!!!";
                }
                else if (totalRoll == 2 || totalRoll == 3 || totalRoll == 12)
                {
                    return "CRAPS!";
                }
                return "";
            }


            string answer = "y";
            while (answer == "y" || answer == "Y")
            {
                if (diceSides == 6)
                {
                    int roll1 = generateRolls(1, 7); //creates a random roll using numbers 1-6 for a 6 sided dice
                    int roll2 = generateRolls(1, 7);
                    Console.WriteLine("You rolled " + roll1 + " and " + roll2);
                    Console.WriteLine((roll1 + roll2) + " Total.");
                    string response = returnCombos(roll1, roll2);
                    string response2 = returnTotals(roll1, roll2);
                    Console.WriteLine(response);
                    Console.WriteLine(response2);
                }
                else
                {
                    int roll1x = generateRolls(1, y + 1); // creates a random roll using numbers 1 through whatever dice side plus 1, so it's inclusive
                    int roll2x = generateRolls(1, y + 1);
                    Console.WriteLine("You rolled " + roll1x + " and " + roll2x);
                    Console.WriteLine((roll1x + roll2x) + " Total.");
                }

                Console.WriteLine("Do you want to roll again (y/n)?");
                answer = Console.ReadLine();

            }
            Console.WriteLine("Thank you for playing!");

        }


    }
}
    

