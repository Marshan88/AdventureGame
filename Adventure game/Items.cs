using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_game
{
    public static class Items
    {

        public static void Inventory()
        {
            string[] itemList = {
                "Bilgewater key",
                "Shuriman key",
                "Targonian key",
                "Bilgewater tellstone",
                "Shuriman tellstone",
                "Targonian tellstone",
                "Bilgewater map",
                "Shuriman map",
                "Targonian map"
            };

            bool bilgewaterMap = false;
            bool shurimanMap = false;
            bool targonianMap = false;

            bool bilgewaterKey = false;
            bool shurimanKey = false;
            bool targonianKey = false;

            bool bilgewaterTellstone = false;
            bool shurimanTellstone = false;
            bool targonianTellstone = false;

            //bool commonWeapoon;
            //bool rareWeapon;
            //bool epicWeapon;
            //bool legendaryWeapoon;
            //bool commonArmor;
            //bool rareArmor;
            //bool epicArmor;
            //bool legendaryArmor;

            if (bilgewaterMap == true)
            {
                Console.WriteLine("You've found a Bilgewater map");
            }
            if (bilgewaterKey == true)
            {
                Console.WriteLine("You've found a Bilgewater key");
            }
            if (bilgewaterTellstone == true)
            {
                Console.WriteLine("you've found a Bilgewater tellstone");
            }

            if (shurimanMap == true)
            {
                Console.WriteLine("You've found a map of Shurima");
            }
            if (shurimanKey == true)
            {
                Console.WriteLine("You've found a Shuriman key");
            }
            if (shurimanTellstone == true)
            {
                Console.WriteLine("you've found a Shuriman tellstone");
            }

            if (targonianMap == true)
            {
                Console.WriteLine("You've found a map of Targon");
            }
            if (targonianKey == true)
            {
                Console.WriteLine("You've found a Targonian key");
            }
            if (targonianTellstone == true)
            {
                Console.WriteLine("you've found a Targonian tellstone");
            }
        }

        public static Boolean isTrue(Boolean b)
        {
            return !isFalse(b);
        }

        public static Boolean isFalse(Boolean b)
        {
            return !isTrue(b);
        }
    }
}