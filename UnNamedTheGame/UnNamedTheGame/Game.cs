using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UnNamedTheGame
{
    class Game
    {
        int room = 0;
        int coin = 0;
        int potion = 0;
        int sword = 0;
        int key = 0;
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
                    GameInfoStart();
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
        private void GameInfoStart()
        {
            Clear();
            WriteLine("You wake up between a town and a forest...");
            ReadKey(true);
            WriteLine("You have no recollection of your name, so you decide to venture out to learn more about yourself.");
            ReadKey(true);
            RunTownChoice();
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
                    RunForestChoice();
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
                    if (potion < 11)
                    {
                        WriteLine("\nThe mysterious man stares at you, and you decide to go against your choice.");
                        ReadKey(true);
                    }
                    else
                    {
                        WriteLine("So, there are multiple endings to this game. You might die in the forest.");
                        ReadKey(true);
                    }
                    RunInnChoice();
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Yellow;
                    
                    if (coin > 0)
                    {
                        WriteLine("\nThe InnKeeper stares at you.\nWhy haven't you left yet? He wants to see you.");
                        ReadKey(true);
                        RunInnChoice();
                    }
                    else if (coin < 1)
                    {
                        WriteLine("\nThe InnKeeper informs you that any new faces should see the GuildMaster first. She hands you a gold coin");
                        coin++;
                        ReadKey(true);
                        RunInnChoice();

                    }
                    break;

                case 2:
                    if (room < 3 )
                    {
                        ForegroundColor = ConsoleColor.Gray;
                        WriteLine("\nThe room is locked, you cannot get in.\nPress any key to continue...");
                        room++;
                        ReadKey(true);
                        RunInnChoice();
                        
                    }
                    else if (room >= 3 && room <5 ) 
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
                    else if (coin == 1000)
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
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    if (potion < 11)
                    {
                        WriteLine("\nThe mysterious man stares at you, and you decide to go against your choice and walk away.");
                        ReadKey(true);
                    }
                    else
                    {
                        WriteLine("So, there are multiple endings to this game. One is repeatedly trying to open the locked door.");
                        ReadKey(true);
                    }
                    RunGuildChoice();
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Blue;
                    if (coin > 0)
                    {
                        WriteLine("\nThe Guild Leader smiles, and sprints towards you. He wraps his arm around you and whispers...");
                        WriteLine("Heres a couple more coins, head to the store next door over.");
                        WriteLine("You now have a total of 9 coins");
                        coin = 8;
                        ReadKey(true);
                        RunTownChoice();
                    }
                    else if (coin < 1)
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
                    if (potion < 11)
                    {
                        WriteLine("\nThe mysterious man stares at you, and you decide to go against your choice.");
                        ReadKey(true);
                    }
                    else
                    {
                        WriteLine("So, there are multiple endings to this game.");
                        ReadKey(true);
                    }
                    RunShopChoice();
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Blue;
                    if (coin <2)
                    {
                        WriteLine("You look like you're too poor for this shop here.");
                        WriteLine("You should check with the GuildLeader before you check with me.");
                        WriteLine("Press any key to continue...");
                        ReadKey(true);
                        RunShopChoice();
                    }
                    else if (coin > 2)
                    {
                        WriteLine("Here, have these poison potions and talk to the mysterious men.");
                        potion = 12;
                        WriteLine("You have recieved 12 potions!");
                        ReadKey(true);
                        RunShopChoice();
                    }
                    break;
                case 2:
                    if (sword < 1)
                    {
                        string prompt1 = "Ahh yes, a sword. Would you like to purchase for 8 coins?";
                        ResetColor();
                        string[] options1 = { "Yes", "No" };
                        Menu locationMenu1 = new Menu(prompt1, options1);
                        int selectedIndex1 = locationMenu1.Run();
                        switch (selectedIndex1)
                        {
                            case 0:
                                WriteLine("You have purchased a silver sword for 8 coins");
                                WriteLine(@"
         />_________________________________
[########[]_________________________________>
         \>"); //https://www.asciiart.eu/weapons/swords
                                ReadKey(true);
                                sword++;
                                break;
                            case 1:
                                WriteLine("You decided against purchasing a sword");
                                ReadKey(true);
                                break;
                        }
                        RunShopChoice();
                    }
                    else
                    {
                        WriteLine("You have already purchased the sword.");
                        WriteLine("Press any key to continue...");
                        ReadKey(true);
                        RunShopChoice();
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
        private void RunForestChoice()
        {
            string prompt = "Where would you like to go?";
            string[] options = { "Deeper into the woods", "Flaming Tree", "Treasure Chest" , "Leave" };
            Menu locationMenu = new Menu(prompt, options);
            int selectedIndex = locationMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine("\nYou walked deeper and found nothing.");
                    WriteLine("Press any key to continue");
                    ReadKey(true);
                    RunForestChoice();
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("You walk near a flaming tree. Above you, you hear a dragon screech");
                    if (sword ==1)
                    {
                        WriteLine("You pull out your sword and decide it's a fight to the death...");
                        ReadKey(true);
                        WriteLine("The dragon descends on top of you with an attempt to grab you.");
                        WriteLine("You thrust your sword onto the dragon to fend it off...");
                        ReadKey(true);
                        WriteLine("The dragon flies away, but you see a key on the ground.");
                        WriteLine(@"
    _____________
   /      _      \
   [] :: (_) :: []
   [] ::::::::: []
   [] ::::::::: []
   [] ::::::::: []
   [] ::::::::: []
   [_____________]
       I     I
       I_   _I
        /   \
        \   /
        (   )   
        /   \
        \___/");
                        //ascii art found here https://ascii.co.uk/art/key
                        key++;
                        
                    }
                    else
                    {
                        WriteLine("You turn to stare at the tree and a dragon is coming straight at you.");
                        ReadKey(true);
                        WriteLine("You decide to turn tail and run, but you are set ablaze by the dragon.");
                        WriteLine("This is it for your journey. You are laid to rest.");
                        ReadKey(true);
                        ExitGame();
                    }
                    ReadKey(true);
                    RunForestChoice();
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("\nYou arrive at a treasure chest");
                    if (key ==1)
                    {
                        WriteLine("You open the chest and are awarded with 1000 coins and another key.");
                        WriteLine(@"
     8 8 8 8                     ,ooo.
     8a8 8a8                    oP   ?b
    d888a888zzzzzzzzzzzzzzzzzzzz8     8b
     `""^""'                    ?o___oP'"); //https://ascii.co.uk/art/key
                        room = 1000;
                        coin = 1000;
                        ReadKey();
                    }
                    else
                    {
                        WriteLine("It looks like you need a key to unlock this");
                    }
                    ReadKey(true);
                    RunForestChoice();
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
