using System;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            string[] choices = new string[3] {
                "rock",
                "paper",
                "scissors"
            };

            bool playing = true;
            string results = "";

            while (playing)
            {
                Random rand = new Random();
                int index = rand.Next(choices.Length);
                string compChoice = choices[index];
                System.Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                System.Console.WriteLine(@"What would you like to do?
(P)lay
(V)iew Choices
(Q)uit");

                ConsoleKeyInfo userInput = System.Console.ReadKey();

                if (userInput.Key == ConsoleKey.P)
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Lets Play!");
                    System.Console.WriteLine(@"Choose your weapon!
        (R)ock | (P)aper | (S)cissors");
                    ConsoleKeyInfo userChoice = System.Console.ReadKey();
                    System.Console.WriteLine("");
                    if (userChoice.Key == ConsoleKey.R)
                    {
                        if (compChoice == "scissors")
                        {
                            System.Console.WriteLine("YOU WIN");
                            results = "win";
                        }
                        else if (compChoice == "paper")
                        {
                            System.Console.WriteLine("YOU LOSE");
                            results = "lose";
                        }
                        else
                        {
                            System.Console.WriteLine("YOU TIE");
                            results = "tie";
                        }
                    }
                    else if (userChoice.Key == ConsoleKey.P)
                    {
                        if (compChoice == "rock")
                        {
                            System.Console.WriteLine("YOU WIN");
                            results = "win";
                        }
                        else if (compChoice == "scissors")
                        {
                            System.Console.WriteLine("YOU LOSE");
                            results = "lose";
                        }
                        else
                        {
                            System.Console.WriteLine("YOU TIE");
                            results = "tie";
                        }
                    }
                    else if (userChoice.Key == ConsoleKey.S)
                    {
                        if (compChoice == "paper")
                        {
                            System.Console.WriteLine("YOU WIN");
                            results = "win";
                        }
                        else if (compChoice == "rock")
                        {
                            System.Console.WriteLine("YOU LOSE");
                            results = "lose";
                        }
                        else
                        {
                            System.Console.WriteLine("YOU TIE");
                            results = "tie";
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Input");
                    }
                }
                else if (userInput.Key == ConsoleKey.V)
                {
                    System.Console.WriteLine(@"
        Rock | Paper | Scissors");
                }
                else if (userInput.Key == ConsoleKey.Q)
                {
                    System.Console.WriteLine("Bye, Felicia");
                    playing = false;
                }
                else
                {
                    System.Console.WriteLine("Invalid Input");
                }
                if (results == "win")
                {
                    System.Console.WriteLine("Great job defeating the AI!");
                }
                else if (results == "lose")
                {
                    System.Console.WriteLine("Wow, you suck...");
                }
                else
                {
                    System.Console.WriteLine("Meh, Try Again");
                }

            }

        }
    }
}
