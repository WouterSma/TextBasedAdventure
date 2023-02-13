using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class Program
    {
        static void Main()
        {
            MainMenu();       
        }
        private static void MainMenu()
        {
            Console.WriteLine("Main Menu\nPlease select:\n1. Start Game\n2. Exit");
            string choice = "";
            do
            {
                Console.WriteLine("Please enter 1 or 2");
                Console.Write(">");
                choice = Console.ReadLine();
            }
            while (!(choice == "1" || choice == "2"));

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You find yourself trapped in a haunted mansion and must solve puzzles to escape.");
                    Console.WriteLine("Choose wisely, as each decision may lead to a different outcome.");
                    Library();
                    break;
                case "2":
                    Console.WriteLine("You exit the game...");
                    break;
            }
            Console.ReadKey();
        }
        private static void ShowInventory()
        {

        } 
        private static void Library()
        {
            Console.WriteLine("You are in the library. You see two doors, a map on the wall, and a chest in the corner.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Go through door 1");
            Console.WriteLine("2. Go through door 2");
            Console.WriteLine("3. Look at the map");
            Console.WriteLine("4. Open the chest");
            string choice = "";
            do
            {
                Console.WriteLine("Please enter 1-4");
                Console.Write(">");
                choice = Console.ReadLine();
            } 
            while (!(choice == "1" || choice == "2" || choice == "3" || choice == "4"));
            switch (choice)
            {
                case "1":
                    RoomOne();
                    break;
                case "2":
                    RoomTwo();
                    break;
                case "3":
                    LibraryMap();
                    break;
                case "4":
                    LibraryChest();
                    break;
            }
            
        }

        private static void RoomOne()
        {
            Console.WriteLine("bla");

        }
        private static void RoomTwo()
        {

        }
        private static void LibraryMap()
        {

        }
        private static void LibraryChest()
        {

        }


    }

}

