using System.Media;

namespace CyberChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CyberChatBot";

            PlayVoiceGreeting();
            DisplayAsciiArt();
            PrintDivider();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hi there! What is your name? ");
            Console.ResetColor();
            string userName = Console.ReadLine();

            Console.Clear();
            DisplayAsciiArt();
            SimulateTyping($"\nNice to meet you, {userName}! I'm your Cybersecurity Awareness Bot.");
            SimulateTyping("Ask me anything about cybersecurity or type 'exit' to leave.");
        }

        static void PlayVoiceGreeting()
        {
            try
            {
                string filePath = "Audio/welcome.wav";
                SoundPlayer player = new SoundPlayer(filePath);
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Could not play voice greeting: " + ex.Message);
                Console.ResetColor();
            }
        }

        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
+------------------------------------------------------------+
|                                                            |
|    _____                            ____        _          |
|   / ____|                          |  _ \      | |         |
|  | (___   ___  ___ _   _ _ __ ___  | |_) | ___ | |_        |
|   \___ \ / _ \/ __| | | | '__/ _ \ |  _ < / _ \| __|       |
|   ____) |  __/ (__| |_| | | |  __/ | |_) | (_) | |_        |
|  |_____/ \___|\___|\__,_|_|  \___| |____/ \___/ \__|       |
|                                                            |
+------------------------------------------------------------+
");
            Console.ResetColor();
        }

        static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n" + new string('-', 60));
            Console.ResetColor();
        }

        static void SimulateTyping(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }
    }
}



