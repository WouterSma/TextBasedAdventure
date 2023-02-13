using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class Program
    {
        private static bool creatureAlive = true;
        static void Main()
        {
            MainMenu();       
        }
        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu\nPlease select:\n1. Start Game\n2. Exit");
            string choice;
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
                    Console.Clear();
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
            string choice; ;
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
                    Console.Clear();
                    RoomOne();
                    break;
                case "2":
                    Console.Clear();
                    RoomTwo();
                    break;
                case "3":
                    Console.Clear();
                    LibraryMap();
                    break;
                case "4":
                    Console.Clear();
                    LibraryChest();
                    break;
            }
            
        }

        private static void RoomOne()
        {
            Console.WriteLine("You find yourself in a dark and eerie room. The room is lit only by a few flickering candles, casting strange shadows on the walls. You see a small table in the center of the room, on top of which sits an ancient-looking book. The room is silent except for the soft rustling of pages as you approach the table. You reach out to open the book and suddenly, a hand grabs yours from underneath the table! What do you do?");
            Console.WriteLine("1. Try to pull your hand free");
            Console.WriteLine("2. Try to see who or what is grabbing your hand");

            string choice;
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
                    Console.Clear();
                    Console.WriteLine("As you yank your hand with all your might, you finally manage to pull it free from the grasp of whatever is holding it. Your heart is racing and your breaths come in short gasps, but you're finally free. You run back to the library and shut the door to room 1 behind you.");
                    Library();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("As you try to see what is grabbing your hand, you suddenly hear a low growl. The growl gets louder and louder until a creature steps out of the shadows. It's unlike anything you've ever seen before. It's tall and lanky with glowing red eyes. The creature speaks in a raspy voice, 'To escape this room, you must answer my riddle. If you get it wrong, you will be trapped here forever. 'I am light as a feather, yet the strongest man cannot hold me for much longer than a minute.What am I ?'");
                    Console.WriteLine("You think for a moment and then respond with your answer");
                    Console.Write(">");
                    string riddleAnswer = Console.ReadLine().ToLower();
                    if (riddleAnswer == "breath" || riddleAnswer == "air")
                    {
                        Console.Clear();
                        Console.WriteLine("The creature nods its head, and the grip on your hand loosens.The creature says, 'You have proven yourself worthy. The exit is now open.'");
                        Winner("Hatch");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The creature shakes its head, 'Wrong answer. You will now be trapped here forever.'");
                        Loser();
                    }
                    break;
            }


        }
        private static void RoomTwo()
        {
            string choice;
            if (creatureAlive)
            {
                Console.WriteLine("As you enter Room 2, you see a shady looking creature in the corner. It doesn't seem to be aggressive, but you're not sure if you can trust it. What do you want to do?");
                Console.WriteLine("1. Attack the creature");
                Console.WriteLine("2. Ignore it and see what you can find in the room");
                Console.WriteLine("3. Turn around and go back the way you came from");
                do
                {
                    Console.WriteLine("Please enter 1-3");
                    Console.Write(">");
                    choice = Console.ReadLine();
                }
                while (!(choice == "1" || choice == "2" || choice == "3"));
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You grab a nearby weapon and engage in battle with the creature. After a grueling fight, you emerge victorious but exhausted.");
                        creatureAlive = false;
                        break;
                    case "2":
                        SearchRoomTwo();
                        break;
                    case "3":
                        Console.WriteLine("Scared by the creature, you slowly back up into the library.");
                        Library();
                        break;


                }
            }
            else
            {
                Console.WriteLine("The creature lays in a pool of blood in the corner of the room");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Search the room");
                Console.WriteLine("2. Leave");
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
                        SearchRoomTwo();
                        break;
                    case "2":
                        Console.WriteLine("You choose to go back to the library");
                        Library();
                        break;
                }
            }


        }

        static void SearchRoomTwo()
        {
            Console.WriteLine("You search the room and notice a heavy metal hatch in the middle of the room. Do you want to try to open it?");
            Console.WriteLine("1. Try to open it");
            Console.WriteLine("2. Go back to the library");
            string choice;
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

                case "2":
                    Console.WriteLine("You look at the hatch and decide to ignore it and go back to the library");
                    Library();
                    break;
            }

        }

        private static void LibraryMap()
        {

        }
        private static void LibraryChest()
        {

        }
        private static void Loser()
        {
            Console.WriteLine("You failed to escape the haunted mansion!");
            Console.WriteLine("Press any key to continue");
            Console.Write(">");
            Console.ReadKey();
            Main();
        }
        private static void Winner(string wayOut)
        {
            switch (wayOut)
            {
                case "Hatch":
                    Console.WriteLine("The room begins to shake and a hidden hatch opens up in the ground. You quickly climb down the ladder and find yourself in a long, dark tunnel. You follow the tunnel and eventually see light at the end. You increase your pace and finally reach the end, where you find yourself outside of the mansion, free at last.");
                    Console.WriteLine("You succesfully escaped the haunted mansion!");
                    Console.WriteLine("Press any key to continue");
                    Console.Write(">");
                    Console.ReadKey();
                    break;

            }
            Main();
        }

    }

}

