using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_game
{
    public static class ASCII
    {
        public static string GameTitle()
        {
            Console.Title = "Made by Lord_Marshan";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string gameTitle = @"__________                     .__    .__                   __  .__                                          .__  __   
\______   \ ____ _____    ____ |  |__ |__| ____    ____   _/  |_|  |__   ____     ________ __  _____   _____ |__|/  |_ 
 |       _// __ \\__  \ _/ ___\|  |  \|  |/    \  / ___\  \   __\  |  \_/ __ \   /  ___/  |  \/     \ /     \|  \   __\
 |    |   \  ___/ / __ \\  \___|   Y  \  |   |  \/ /_/  >  |  | |   Y  \  ___/   \___ \|  |  /  Y Y  \  Y Y  \  ||  |  
 |____|_  /\___  >____  /\___  >___|  /__|___|  /\___  /   |__| |___|  /\___  > /____  >____/|__|_|  /__|_|  /__||__|  
        \/     \/     \/     \/     \/        \//_____/              \/     \/       \/            \/      \/          ";
            Console.WriteLine(gameTitle);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Adventure Game\n\n");
            Console.ResetColor();
            Console.WriteLine("                                                  Press ENTER to start");
            Console.ReadKey();
            Console.Clear();
            return gameTitle;
        }
        public static string BilgewaterTitle()
        {
            Console.Title = "Bilgewater";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"__________.__.__                                 __                
\______   \__|  |    ____   ______  _  _______ _/  |_  ___________ 
 |    |  _/  |  |   / ___\_/ __ \ \/ \/ /\__  \\   __\/ __ \_  __ \
 |    |   \  |  |__/ /_/  >  ___/\     /  / __ \|  | \  ___/|  | \/
 |______  /__|____/\___  / \___  >\/\_/  (____  /__|  \___  >__|   
        \/        /_____/      \/             \/          \/       ";
            Console.WriteLine(ascii);
            Console.ResetColor();
            return ascii;
        }
        public static string FirstBilgewaterScenarioTitle()
        {
            Console.Title = "Act: 1/3, Scenario: 1/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"  ________              ___.   .__              /\                                                
 /  _____/_____    _____\_ |__ |  |   __________)/ ______   ____  ___________  ____   ___________ 
/   \  ___\__  \  /     \| __ \|  | _/ __ \_  __ \/  ___/ _/ ___\/  _ \_  __ \/    \_/ __ \_  __ \
\    \_\  \/ __ \|  Y Y  \ \_\ \  |_\  ___/|  | \/\___ \  \  \__(  <_> )  | \/   |  \  ___/|  | \/
 \______  (____  /__|_|  /___  /____/\___  >__|  /____  >  \___  >____/|__|  |___|  /\___  >__|   
        \/     \/      \/    \/          \/           \/       \/                 \/     \/       ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string SecondBilgewaterScenarioTitle()
        {
            Console.Title = "Act: 2/3, Scenario: 2/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"__________        __         .__                /\        ___.         .__    .___              
\______   \__ ___/  |_  ____ |  |__   __________)/ ______ \_ |_________|__| __| _/ ____   ____  
 |    |  _/  |  \   __\/ ___\|  |  \_/ __ \_  __ \/  ___/  | __ \_  __ \  |/ __ | / ___\_/ __ \ 
 |    |   \  |  /|  | \  \___|   Y  \  ___/|  | \/\___ \   | \_\ \  | \/  / /_/ |/ /_/  >  ___/ 
 |______  /____/ |__|  \___  >___|  /\___  >__|  /____  >  |___  /__|  |__\____ |\___  / \___  >
        \/                 \/     \/     \/           \/       \/              \/_____/      \/ ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string ThirdBilgewaterScenarioTitle()
        {
            Console.Title = "Act: 3/3, Scenario: 3/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"__________.__                    .___ .__           __  .__                              __                
\______   \  |   ____   ____   __| _/ |__| ____   _/  |_|  |__   ____   __  _  _______ _/  |_  ___________ 
 |    |  _/  |  /  _ \ /  _ \ / __ |  |  |/    \  \   __\  |  \_/ __ \  \ \/ \/ /\__  \\   __\/ __ \_  __ \
 |    |   \  |_(  <_> |  <_> ) /_/ |  |  |   |  \  |  | |   Y  \  ___/   \     /  / __ \|  | \  ___/|  | \/
 |______  /____/\____/ \____/\____ |  |__|___|  /  |__| |___|  /\___  >   \/\_/  (____  /__|  \___  >__|   
        \/                        \/          \/             \/     \/                \/          \/       ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string ShurimaTitle()
        {
            Console.Title = "Shurima";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"  _________.__                 .__                
 /   _____/|  |__  __ _________|__| _____ _____   
 \_____  \ |  |  \|  |  \_  __ \  |/     \\__  \  
 /        \|   Y  \  |  /|  | \/  |  Y Y  \/ __ \_
/_______  /|___|  /____/ |__|  |__|__|_|  (____  /
        \/      \/                      \/     \/ ";
            Console.WriteLine(ascii);
            Console.ResetColor();
            return ascii;
        }
        public static string FirstShurimaScenarioTitle()
        {
            Console.Title = "Act: 2/3, Scenario: 1/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"___________.__                          .__                        _____         .__                 .__                
\__    ___/|  |__   ____   _______ __ __|__| ____   ______   _____/ ____\   _____|  |__  __ _________|__| _____ _____   
  |    |   |  |  \_/ __ \  \_  __ \  |  \  |/    \ /  ___/  /  _ \   __\   /  ___/  |  \|  |  \_  __ \  |/     \\__  \  
  |    |   |   Y  \  ___/   |  | \/  |  /  |   |  \\___ \  (  <_> )  |     \___ \|   Y  \  |  /|  | \/  |  Y Y  \/ __ \_
  |____|   |___|  /\___  >  |__|  |____/|__|___|  /____  >  \____/|__|    /____  >___|  /____/ |__|  |__|__|_|  (____  /
                \/     \/                       \/     \/                      \/     \/                      \/     \/ ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string SecondShurimaScenarioTitle()
        {
            Console.Title = "Act: 2/3, Scenario: 2/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"_________                                  .___              .__                    
\_   ___ \_____    ______ ____ _____     __| _/____   _______|__|__  __ ___________ 
/    \  \/\__  \  /  ___// ___\\__  \   / __ |/ __ \  \_  __ \  \  \/ // __ \_  __ \
\     \____/ __ \_\___ \\  \___ / __ \_/ /_/ \  ___/   |  | \/  |\   /\  ___/|  | \/
 \______  (____  /____  >\___  >____  /\____ |\___  >  |__|  |__| \_/  \___  >__|   
        \/     \/     \/     \/     \/      \/    \/                       \/       ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string ThirdShurimaScenarioTitle()
        {
            Console.Title = "Act: 2/3, Scenario: 3/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"  _________.__                 .__                               ___.                        
 /   _____/|  |__  __ _________|__| _____ _____    _______   ____\_ |__   ___________  ____  
 \_____  \ |  |  \|  |  \_  __ \  |/     \\__  \   \_  __ \_/ __ \| __ \ /  _ \_  __ \/    \ 
 /        \|   Y  \  |  /|  | \/  |  Y Y  \/ __ \_  |  | \/\  ___/| \_\ (  <_> )  | \/   |  \
/_______  /|___|  /____/ |__|  |__|__|_|  (____  /  |__|    \___  >___  /\____/|__|  |___|  /
        \/      \/                      \/     \/               \/    \/                  \/ ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string TargonTitle()
        {
            Console.Title = "Targon";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"___________                                  
\__    ___/____ _______  ____   ____   ____  
  |    |  \__  \\_  __ \/ ___\ /  _ \ /    \ 
  |    |   / __ \|  | \/ /_/  >  <_> )   |  \
  |____|  (____  /__|  \___  / \____/|___|  /
               \/     /_____/             \/ ";
            Console.WriteLine(ascii);
            Console.ResetColor();
            return ascii;
        }
        public static string FirstTargonScenarioTitle()
        {
            Console.Title = "Act: 3/3, Scenario: 1/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"___________.__               _____                                   .__  .__   
\__    ___/|  |__   ____   _/ ____\____ _______   ______  _  __ ____ |  | |  |  
  |    |   |  |  \_/ __ \  \   __\\__  \\_  __ \_/ __ \ \/ \/ // __ \|  | |  |  
  |    |   |   Y  \  ___/   |  |   / __ \|  | \/\  ___/\     /\  ___/|  |_|  |__
  |____|   |___|  /\___  >  |__|  (____  /__|    \___  >\/\_/  \___  >____/____/
                \/     \/              \/            \/            \/           ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string SecondTargonScenarioTitle()
        {
            Console.Title = "Act: 3/3, Scenario: 2/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"___________                      .__              
\__    ___/______ __ __   ____   |__| ____  ____  
  |    |  \_  __ \  |  \_/ __ \  |  |/ ___\/ __ \ 
  |    |   |  | \/  |  /\  ___/  |  \  \__\  ___/ 
  |____|   |__|  |____/  \___  > |__|\___  >___  >
                             \/          \/    \/ ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string ThirdTargonScenarioTitle()
        {
            Console.Title = "Act: 3/3, Scenario: 3/3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"__________                     .__    .__                   __  .__                                          .__  __   
\______   \ ____ _____    ____ |  |__ |__| ____    ____   _/  |_|  |__   ____     ________ __  _____   _____ |__|/  |_ 
 |       _// __ \\__  \ _/ ___\|  |  \|  |/    \  / ___\  \   __\  |  \_/ __ \   /  ___/  |  \/     \ /     \|  \   __\
 |    |   \  ___/ / __ \\  \___|   Y  \  |   |  \/ /_/  >  |  | |   Y  \  ___/   \___ \|  |  /  Y Y  \  Y Y  \  ||  |  
 |____|_  /\___  >____  /\___  >___|  /__|___|  /\___  /   |__| |___|  /\___  > /____  >____/|__|_|  /__|_|  /__||__|  
        \/     \/     \/     \/     \/        \//_____/              \/     \/       \/            \/      \/          ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
        public static string TheEnd()
        {
            Console.Title = "Thanks for playing";
            Console.ForegroundColor = ConsoleColor.Yellow;
            const string ascii = @"___________.__                                .___
\__    ___/|  |__   ____     ____   ____    __| _/
  |    |   |  |  \_/ __ \  _/ __ \ /    \  / __ | 
  |    |   |   Y  \  ___/  \  ___/|   |  \/ /_/ | 
  |____|   |___|  /\___  >  \___  >___|  /\____ | 
                \/     \/       \/     \/      \/ ";
            Console.WriteLine(ascii);
            Console.WriteLine("________________________________________________________________________________________________________________________\n\n");
            Console.ResetColor();
            return ascii;
        }
    }
}




