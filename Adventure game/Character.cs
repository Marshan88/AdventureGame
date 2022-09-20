using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_game
{
    public static class Character
    {
        static int luck = 5;
        static Random randomNumber = new Random();
        public static int points = 0;

        public static void NameCharacter()
        {
            Console.Title = "Character Setup";
            GameDialog.Text("\nName your character:\n");
            string CharacterNaming = Console.ReadLine();
            GameDialog.Dialog("\nWelcome to Runeterra, " + CharacterNaming + "!\n\n");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static bool Luck()
        {
            int karma = randomNumber.Next(10);
            bool result = false;

            if (luck >= karma) 
            {
                result = true;
            }

            return result;
        }

        public static void ShowLuck()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Luck Roll";
            Console.WriteLine("Your points:" + Character.points);
            for(int i = 0; i < 20; i++)
            {
                if (Character.Luck())
                {
                    Console.WriteLine("Your luck has gained you another point!");
                    Character.points++;
                }
                else
                {
                    Console.WriteLine("Your luck has failed... You've lost a point.");
                    Character.points--;
                }
                Console.WriteLine("Your points: " + Character.points);
                Console.Read();
                Console.ResetColor();
            }
        }

        public static void Fight()
        {

        }

        public static void RunAway()
        {

        }

        public static void UseItem()
        {

        }
    }
}
