using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    enum GameState
    {
        Start,
        Play,
        Exit,
        End
    }

    class Program
    {
        static void Main()
        {
            GameState currentState = GameState.Start;

            while (currentState != GameState.End)
            {
                switch (currentState)
                {
                    case GameState.Start:
                        Console.WriteLine("Welcome to the game!");
                        Console.WriteLine("Make a choice:");
                        Console.WriteLine("1. Start Game");
                        Console.WriteLine("2. Exit");
                        Console.Write(">");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            currentState = GameState.Play;
                        }
                        else if (choice == "2")
                        {
                            currentState = GameState.Exit;
                        } 
                        else
                        {
                            Console.WriteLine("Please enter 1 to start or 2 to exit");
                            Console.Write(">");
                            choice = Console.ReadLine();
                        }
                        break;

                    case GameState.Play:
                        Console.WriteLine("You chose to play the game.");
                        Console.WriteLine("There's nothing here yet.");
                        currentState = GameState.Exit;
                        break;

                    case GameState.Exit:
                        Console.WriteLine("You chose to exit the game.");
                        currentState = GameState.End;
                        break;
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }

}

