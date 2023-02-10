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
        Choice1,
        Choice2,
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
                        Console.WriteLine("1. Option 1");
                        Console.WriteLine("2. Option 2");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            currentState = GameState.Choice1;
                        }
                        else if (choice == "2")
                        {
                            currentState = GameState.Choice2;
                        }
                        break;

                    case GameState.Choice1:
                        Console.WriteLine("You chose Option 1.");
                        currentState = GameState.Choice1;
                        break;

                    case GameState.Choice2:
                        Console.WriteLine("You chose Option 2.");
                        currentState = GameState.End;
                        break;
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }

}

