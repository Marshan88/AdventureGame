using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure_game
{
    //  >  <
    internal class GameDialog
    {
        public static void Typewrite(string message)
        {
            var random = new Random();
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(random.Next(20, 80));
            }
            Thread.Sleep(500);
        }

        public static void Dialog(string dialog)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Typewrite(dialog);
            Console.ResetColor();
        }

        public static void Text(string text)
        {
            Typewrite(text);
        }

        public static void Options(string options)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(options);
            Console.ResetColor();
        }

        public string Answer()
        {
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            return answer;
        }

        public static void BilgewaterIntro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("\n\nNestled away in the Blue Flame Isles acrhipelago,");
            Console.WriteLine("Bilgewater is a port city like no other--home to serpent hunters, dock gangs, and smugglers from across the world. ");
            Console.WriteLine("Here, forunes are made and ambitions shattered in the blink of an eye. ");
            Console.WriteLine("For those fleeing justice, debt, or percecution, Bilgewater can be a place of new beginnings,");
            Console.WriteLine("for no one on these twisted streets cares about your past.");
            Console.WriteLine("Even so, with each new dawn, careless travelers can always be found floating in the harbor,");
            Console.WriteLine("their purses empty and their throats slit...\n");
            Console.WriteLine("\nWhile incredibly dangerous, Bilgewater is ripe with opportunity,");
            Console.WriteLine("free from the shackles of formal government and trade regulation.");
            Console.WriteLine("If you have the coin, almost anything can be purchased here, from outlawed hextech to the favor of local crime lords.");
            Console.WriteLine("\nWith the recent removal of the last 'reaver king' of Bilgewater, the city has entered a period of transition,");
            Console.WriteLine("while the most prominent camptains try to agree on its future.");
            Console.WriteLine("But as long as there are seaworthy ships and crews to sail them,");
            Console.WriteLine("Bilgewater is likely to remain one of the most colorful and well-connected places in Runeterra\n\n");
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ShurimaIntro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("\n\nThe empire of Shurima was once a thriving civilization that spanned an entire continent.");
            Console.WriteLine("Forged in a bygone age by the mighty god - warriors of the Ascended Host,");
            Console.WriteLine("it united all the disparate peoples of the south, and enforced a lasting peace between them.");
            Console.WriteLine("Few dared to rebel. Those that did, like the accursed nation of Icathia, were crushed without mercy.");
            Console.WriteLine("However, after several thousand years of growth and prosperity, the failed Ascension of Shurima’s last emperor left the capital in ruins,");
            Console.WriteLine("the failed Ascension of Shurima’s last emperor left the capital in ruins,");
            Console.WriteLine("and tales of the empire’s former glory became little more than myth.");
            Console.WriteLine("Now, most of the nomadic inhabitants of Shurima’s deserts eke out a meager existence from the unforgiving land.");
            Console.WriteLine("Some have built small outposts to defend the few oases,");
            Console.WriteLine("while others delve into long lost catacombs in search of the untold riches that must surely lay buried there.");
            Console.WriteLine("There are also those who live as mercenaries, taking coin for their service before disappearing back into the lawless wastelands.");
            Console.WriteLine("Still, a handful dare to dream of a return to the old ways.");
            Console.WriteLine("Indeed, more recently the tribes have been stirred by whispers from the heart of the desert—");
            Console.WriteLine("that their emperor Azir has returned, to lead them into a new, wondrous age.\n\n");
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        public static void TargonIntro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("\n\nMount Targon is the mightiest peak in Runeterra,");
            Console.WriteLine("a towering peak of sun - baked rock amid a range of summits unmatched in scale anywhere else in the world. Located far from civilization,");
            Console.WriteLine("Mount Targon is utterly remote and all but impossible to reach save by the most determined seeker.");
            Console.WriteLine("Many legends cling to Mount Targon, and, like any place of myth, it is a beacon to dreamers, madmen and questors of adventure.");
            Console.WriteLine("Some of these brave souls attempt to scale the impossible mountain, perhaps seeking wisdom or enlightenment,");
            Console.WriteLine("perhaps chasing glory or some soul-deep yearning to witness its summit.");
            Console.WriteLine("The ascent is all but impossible, and those hardy few who somehow survive to reach the top almost never speak of what they have seen.");
            Console.WriteLine("Some return with a haunted, empty look in their eyes, others changed beyond all recognition,");
            Console.WriteLine("imbued by an Aspect of unearthly, inhuman power with a destiny few mortals can comprehend.\n\n");
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        //public static void ActOneFirstScenarioDialog()
        //{
        //    int scenarios = 3;
        //    var answer = Console.ReadLine();
        //    _ = answer.ToUpper();

        //    Text("\nA stranger approaches.\n");
        //    Text("Clearing their throat to get your attention, they ask: \n");
        //    Dialog("'Have you seen a strange creature around here?\nabout 1,40 high, greenish, with a hunchback and a bag filled with loot?'\n");
        //    Options("A) Yes\nB) No\nC) Keep walking\n\n");
        //    for (int scenario = 1; scenario <= scenarios; scenario++)
        //    {
        //        switch (scenario)
        //        {
        //            case 1:
        //                break;
        //            case 2:

        //                break;
        //            case 3:

        //                break;
        //            default:
        //                break;
        //        }
        //        Console.ReadKey();
        //    }
        //}

        public static void ActOneFirstScenarioDialog()
        {
            Console.Title = "ACT: 1, SCENARIO: 1";
            Text("\nA stranger approaches.\n");
            Text("Clearing their throat to get your attention, they ask: \n");
            Dialog("'Have you seen a strange creature around here?\nabout 1,40 high, greenish, with a hunchback and a bag filled with loot?'\n");
            Options("\nA) Yes\nB) No\nC) Keep walking\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                Dialog("\n'Ah, so he went that way, you say.. Want to join me and get this sucker?\nThat loot goblin always stealin' anything of value!'\n");
                Options("\n1) Let's go, but only if we split 50/50\n2)Ain't nobody got time for that!\n");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {
                    Dialog("'50/50?! Ugh, fine! Let's go before he gets away.. yeah, i can tell by the smell he went this way'");
                }
                else
                {
                    Dialog("'Well, la-di-da!'");
                }
            }

            else if (answer == "B")
            {
                Dialog("\n'Bah, well can you help me catch it? I'll give you a fair share of the loot! Im not as strong as you,\nso the ekstra brawn would help.'\n");
                Options("\nA) Alright\nB) I'll pass\n");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {
                    Text("\nHis eyes consentrate out in the open\n");
                    Dialog("\n'70/30! since I'm the brain behind this I get more,\npretty sure i know how to find it too.\nNo loot if we can't find that stinky, right?'\n");
                    Text("\nBefore you get to answer, he continues the chase with a bossy attitude in his march..\n");
                    Dialog("\n'Good! it's a deal then, let's move, no time to waste!'\n");
                }
                else
                {
                    Dialog("'Well, don't waste my time then bigot!'\n");
                    Text("He walks away\n");
                }
            }
            else if (answer == "C")
            {
                Text("Confused by your nonchalant passing, he yells\n");
                Dialog("'Well, la-di-da!'");
                Text("To be continued");
            }
            Console.WriteLine("Press ENTER for next scenario");
            Console.ReadKey();
            Console.Clear();
        }


        public static void ActOneSecondScenarioDialog()
        {
            Console.Title = "ACT: 1, SCENARIO: 2";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for next scenario");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ActOneThirdScenarioDialog()
        {
            Console.Title = "ACT: 1, SCENARIO: 3";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for next act");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ActTwoFirstScenarioDialog()
        {
            Console.Title = "ACT: 2, SCENARIO: 1";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for next scenario");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ActTwoSecondScenarioDialog()
        {
            Console.Title = "ACT: 2, SCENARIO: 2";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for next scenario");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ActTwoThirdScenarioDialog()
        {
            Console.Title = "ACT: 2, SCENARIO: 3";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for next act");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ActThreeFirstScenarioDialog()
        {
            Console.Title = "ACT: 3, SCENARIO: 1";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for next scenario");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ActThreeSecondScenarioDialog()
        {
            Console.Title = "ACT: 3, SCENARIO: 2";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for next scenario");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ActThreeThirdScenarioDialog()
        {
            Console.Title = "ACT: 3, SCENARIO: 3";
            Console.WriteLine("\n");
            Dialog("''\n");
            Console.Write("\nA) Yes\nB) No\nC) Maybe\n\n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "A")
            {
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "B")
            {

                if (answer == "A")
                {

                }
                else
                {

                }
            }
            else if (answer == "C")
            {
                if (answer == "A")
                {

                }
                else
                {

                }
            }
            Console.WriteLine("Press ENTER for end credits");
            Console.ReadKey();
            Console.Clear();
        }

        public static void EndDialog()
        {
            Text("Thanks for playing");
            Console.ReadKey();
        }
    }
}
