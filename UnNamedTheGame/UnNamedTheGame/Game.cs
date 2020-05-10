using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UnNamedTheGame
{
    class Game
    {
        int room = 0;
        int Coin = 0;
        public void Start()
        {
            Title = "UnNamed - The Game";
            RunMainMenu();

            ReadKey(true);
        }

        private void RunMainMenu()
        {
            string prompt = @"

  _   _       _   _                          _           _____ _             ____                      
 | | | |_ __ | \ | | __ _ _ __ ___   ___  __| |         |_   _| |__   ___   / ___| __ _ _ __ ___   ___ 
 | | | | '_ \|  \| |/ _` | '_ ` _ \ / _ \/ _` |  _____    | | | '_ \ / _ \ | |  _ / _` | '_ ` _ \ / _ \
 | |_| | | | | |\  | (_| | | | | | |  __/ (_| | |_____|   | | | | | |  __/ | |_| | (_| | | | | | |  __/
  \___/|_| |_|_| \_|\__,_|_| |_| |_|\___|\__,_|           |_| |_| |_|\___|  \____|\__,_|_| |_| |_|\___|


Welcome to the UnNamed = The Game. What would you like to do?
(Use the arrow keys to cycle through options and  press enter to select an option.)";
            
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunTownChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
                default:
                    break;
            }
        }

        private void ExitGame()
        {
            WriteLine("\n Press any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("This game was a demo created by Darrel Jay Stagen");
            WriteLine("It uses assets from http://patorjk.com.software/taag.");
            WriteLine("This is just a demo... full game coming to console near you soon!");
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
        private void RunTownChoice()
        {
            string prompt = "Where would you like to go?";
            string[] options = { "Inn", "Guild", "Shop", "Forest" };
            Menu locationMenu = new Menu(prompt, options);
            int selectedIndex = locationMenu.Run();

            switch(selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("\nYou arrive at the Town Inn.");
                    WriteLine("Press any key to continue");
                    ReadKey(true);
                    RunInnChoice();
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("\nYou arrive at the guild.");
                    WriteLine("Press any key to continue");
                    ReadKey(true);
                    RunGuildChoice();
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("\nYou arrive at the Town Shop.");
                    WriteLine("Press any key to continue");
                    ReadKey(true);
                    RunShopChoice();
                    break;
                case 3:
                    ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine("\nYou arrive at the Forest");
                    WriteLine("Press any key to continue");
                    ReadKey(true);
                    //RunForestChoice();
                    break;
            }
            //ResetColor();
            //WriteLine("Thats all for this game Demo!");
            //ExitGame();
        }
        private void RunInnChoice()
        {

            string prompt = "You barge in through the doors.\n The receptionist stares. You start pathing towards the ___.";
            ResetColor();
            string[] options = { "Mysterious Man", "InnKeeper", "Room" , "Leave" };
            Menu locationMenu = new Menu(prompt, options);
            int selectedIndex = locationMenu.Run();
            

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("\nThe mysterious man stares at you, and you decide to go against your choice and walked past him towards the InnKeeper.");
                    ReadKey(true);
                    RunInnChoice();
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\nThe InnKeeper informs you that any new faces should see the GuildMaster first. She hands you a gold coin");
                    Coin++;
                    ReadKey(true);
                    RunInnChoice();
                    break;

                case 2:
                    if (room < 10)
                    {
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine("\nThe room is locked, you cannot get in.\nPress any key to continue...");
                        room++;
                        ReadKey(true);
                        RunInnChoice();
                        
                    }
                    else if (room >= 3 && room < 1000) 
                    {
                        WriteLine("You broke the lock");
                        WriteLine("The story ends here, you messed up the game...");
                        WriteLine("...");
                        ReadKey(true);
                        WriteLine("You didn't close out yet? \n Get out of here!");
                        WriteLine("...");
                        ReadKey(true);
                        WriteLine("...");
                        ReadKey(true);
                        WriteLine("Ok... I'm closing the game for you. No need to waste time. Yes this is the bad ending.");
                        ReadKey(true);
                        ExitGame();
                        
                    }
                    else if (room == 1000)
                    {
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("I've been waiting for you MrNameTaker...");
                        WriteLine("Press any key to continue");
                        ReadKey(true);
                        ForegroundColor = ConsoleColor.Cyan;
                        WriteLine("No seriously, welcome back home dear, oh dear thats a big bump on your head, please becareful. \nYou know you're prone to Amnesia.\nAs you look around, you see someone with your face on photos all around the room. This is it, this is your home.");
                        WriteLine("Press any key...");
                        ReadKey(true);
                        WriteLine("Congrats for beating my game. This is the good ending.");
                        WriteLine("UnNamed The Game - A game by Dj");
                        WriteLine("Press any key to continue");
                        ReadKey(true);
                    }
                    break;
                case 3:
                    RunTownChoice();
                    break;
                    
            }

            //ResetColor();
            //WriteLine("Thats all for this game Demo!");
            //ExitGame();

        }
        private void RunGuildChoice()
        {
            string prompt = "You barge in through the doors.\n Everyone turns to stare at you. You start pathing towards the ___.";
            ResetColor();
            string[] options = { "Mysterious Man", "Guild Leader", "Bar" , "Leave" };
            Menu locationMenu = new Menu(prompt, options);
            int selectedIndex = locationMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("\nThe mysterious man stares at you, and you decide to go against your choice and walked past him towards the Guild leader.");
                    ReadKey(true);
                    RunGuildChoice();
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Blue;
                    if (Coin > 0)
                    {
                        WriteLine("\nThe Guild Leader smiles, and sprints towards you. He wraps his arm around you and whispers...");
                        WriteLine("Heres a couple more coins, head to the store next.");
                        Coin = 8;
                        ReadKey(true);
                        RunTownChoice();
                    }
                    else if (Coin < 1)
                    {
                        WriteLine("The Guild Leader stares at you menacingly and you look away.");
                        ReadKey(true);
                        RunGuildChoice();
                        
                    }
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.Gray;
                    WriteLine("\nBartender: Your Money isn't good here.");
                    ReadKey(true);
                    RunGuildChoice();
                    break;
                case 3:
                    RunTownChoice();
                    break;
            }

            //ResetColor();
            //WriteLine("Thats all for this game Demo!");
            //ExitGame();

        }

        private void RunShopChoice()
        {
            string prompt = "You barge in through the doors.\nWHY DID YOU BARGE IN? \nYou start pathing towards the shop keeper.";
            ResetColor();
            string[] options = { "Mysterious Man", "ShopKeeper", "Swords", "Leave" };
            Menu locationMenu = new Menu(prompt, options);
            int selectedIndex = locationMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("\nThe mysterious man stares at you, and you decide to go against your choice and walked past him towards the Guild leader.");
                    ReadKey(true);
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Blue;
                    if (Coin > 0)
                    {

                    }
                    else if (Coin < 1)
                    {
                     

                    }
                    break;
                case 2:

                    break;
                case 3:
                    RunTownChoice();
                    break;
            }

            //ResetColor();
            //WriteLine("Thats all for this game Demo!");
            //ExitGame();

        }
    }
}
