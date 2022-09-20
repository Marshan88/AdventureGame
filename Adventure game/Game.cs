using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_game
{
    public static class Game
    {
        public static void StartGame()
        {
            int acts = 3;

            for (int act = 1; act <= acts; act++)
            {
                switch (act)
                {
                    case 1:
                        ASCII.GameTitle();
                        Character.NameCharacter();
                        ASCII.BilgewaterTitle();
                        GameDialog.BilgewaterIntro();
                        ASCII.FirstBilgewaterScenarioTitle();
                        GameDialog.ActOneFirstScenarioDialog();
                        ASCII.SecondBilgewaterScenarioTitle();
                        GameDialog.ActOneSecondScenarioDialog();
                        ASCII.ThirdBilgewaterScenarioTitle();
                        GameDialog.ActOneThirdScenarioDialog();
                        break;
                    case 2:
                        ASCII.ShurimaTitle();
                        GameDialog.ShurimaIntro();
                        ASCII.FirstShurimaScenarioTitle();
                        GameDialog.ActTwoFirstScenarioDialog();
                        ASCII.SecondShurimaScenarioTitle();
                        GameDialog.ActTwoSecondScenarioDialog();
                        ASCII.ThirdShurimaScenarioTitle();
                        GameDialog.ActTwoThirdScenarioDialog();
                        break;
                    case 3:
                        ASCII.TargonTitle();
                        GameDialog.ShurimaIntro();
                        ASCII.FirstTargonScenarioTitle();
                        GameDialog.ActThreeFirstScenarioDialog();
                        ASCII.SecondTargonScenarioTitle();
                        GameDialog.ActThreeSecondScenarioDialog();
                        ASCII.ThirdTargonScenarioTitle();
                        GameDialog.ActThreeThirdScenarioDialog();
                        ASCII.TheEnd();
                        GameDialog.EndDialog();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}