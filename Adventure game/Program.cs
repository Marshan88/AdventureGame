/*
 * [It-developer student]
 * Marius Henriksen
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;

namespace Adventure_game
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight - 20;
            Game.StartGame();
        }
    }
}