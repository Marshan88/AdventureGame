using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_game
{
    internal static class Game
    {
        public static void StartGame()
        {
            string CharacterName = "";
            Console.WriteLine("Game title");
            Console.WriteLine("Name your character:");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Welcome to Runeterra, " + CharacterName);
            Console.ReadKey();
        }
    }
}