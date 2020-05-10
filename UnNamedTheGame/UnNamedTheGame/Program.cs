using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UnNamedTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "UnNamed The Game";
            StartArea FirstArea = new StartArea();
            FirstArea.Run();
            Game myGame = new Game();
            myGame.Start();

           //Shop currentShop = new Shop();
           // currentShop.Run();
        }
    }
}
