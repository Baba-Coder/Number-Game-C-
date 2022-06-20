using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
// Namespace

namespace NumberGuesser
{
    // Main Class

    class Program
    {
        // Entry Point Method 
        static void Main(string[] args)
        {

            GetAppInfo(); // Run GetAppInfo function 

            GreetUser();

       

            while (true)
            {



                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // init guess var 
                int guess = 0;

                // Init correct number 
                // int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number just a random number 0 - 10
                int correctNumber = random.Next(1, 10);


                // while guess is not correct
                while (guess != correctNumber)

                {
                    // Get users input 
                    string input = Console.ReadLine();

                    // Make sure it a number
                    if (!int.TryParse(input, out guess))

                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Please enter an actual number");
                        Thread.Sleep(1000);

                        // Reset text color
                        Console.ResetColor();

                        // Keep going
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)

                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong number, Try again");
                        Thread.Sleep(1000);
                        Console.ResetColor();
                    }

                }

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You are CORRECT!!!");

                Console.ReadLine();

                // Ask to play again
                Console.WriteLine("Play Again? [ Y or N ] ");

                // Get answer
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }

                else if  ( playAgain == "N")
                {
                    return;
        
                }
                else
                {
                    return;
                }

            }

          
        }
        // Get and display App info
        static void GetAppInfo ()
        {
            // Set app vars
            string appName = "Number Guess App";
            string appVersion = "1.0.0";
            string appAuthor = "DrCode\n";



            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine(" {0}\n Version {1}\n By {2}", appName, appVersion, appAuthor);

            // Reset text color 
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Welcome to Number Guess App\n");
            Console.WriteLine("-------------------------------\n\n");

            // Ask user name 
            Console.Write("What is your name?");

            Console.WriteLine();

            // Get user input 
            string userName = Console.ReadLine();

           
            Thread.Sleep(2000);

            Console.WriteLine("Hello {0}, let's play a game...", userName);
            Console.WriteLine();


        }

    }
}
