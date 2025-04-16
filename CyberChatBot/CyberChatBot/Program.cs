using System.Media;
using System.Runtime.InteropServices;

namespace CyberChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CyberChatBot";

            DisplayAsciiArt(); 
            PlayVoiceGreeting(); 

            Console.Clear(); 
            DisplayAsciiArt(); 

            PrintDivider();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Hi there! What is your name? ");
            Console.ResetColor();
            string userName = Console.ReadLine();

            Console.Clear();
            DisplayAsciiArt();
            SimulateTyping($"Nice to meet you, {userName}! I'm your Cybersecurity Awareness Bot.");
            SimulateTyping("Ask me anything about cybersecurity or type 'exit' to leave.");

            while (true)
            {
                PrintDivider();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ResetColor();
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    SimulateTyping("Please enter a valid question.");
                }
                else if (input.Contains("how are you"))
                {
                    SimulateTyping("I'm doing great, thanks for asking!");
                    SimulateTyping($"And how about you, {userName}?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nYou: ");
                    Console.ResetColor();
                    Console.ReadLine();

                    SimulateTyping("Thanks for sharing!");
                }

                else if (input.Contains("purpose"))
                {
                    SimulateTyping("I'm here to help you learn how to protect yourself online.");
                }

                //Infomation on what the chat bot can do
                else if (input.Contains("what can i ask") || input.Contains("what can i ask you about"))
                {
                    SimulateTyping("You can ask me about password safety, phishing scams and safe browsing.");
                    SimulateTyping(
                        "For more specific topics, try asking:\n" +
                        "- What do you know about passwords?\n" +
                        "- What do you know about phishing?\n" +
                        "- What do you know about safe browsing?"
                    );
                }
                else if (input.Contains("what do you know about passwords"))
                {
                    SimulateTyping(
                        "You can ask me questions like:\n" +
                        "- What is a strong password?\n" +
                        "- How often should I change my password?\n" +
                        "- Is it safe to save passwords in the browser?\n" +
                        "- Should I reuse passwords?\n" +
                        "- What is a password manager?"
                    );
                }
                else if (input.Contains("what do you know about phishing"))
                {
                    SimulateTyping(
                        "You can ask me things like:\n" +
                        "- What is phishing?\n" +
                        "- What are examples of phishing?\n" +
                        "- How can I avoid phishing?\n" +
                        "- How do I report phishing?"
                    );
                }
                else if (input.Contains("what do you know about safe browsing"))
                {
                    SimulateTyping(
                        "You can ask questions like:\n" +
                        "- What is safe browsing?\n" +
                        "- How can I browse safely?\n" +
                        "- What does HTTPS mean?"
                    );
                }


                //Passowrd related questions
                else if (input.Contains("how often") && input.Contains("change") && input.Contains("password"))
                {
                    SimulateTyping("It's a good idea to change your passwords every 3 to 6 months or immediately if there's a data breach.");
                }
                else if (input.Contains("secure password") || input.Contains("strong password"))
                {
                    SimulateTyping($"A secure password should include uppercase, lowercase, numbers and special symbols. Example: {userName}@It2025!");
                }
                else if (input.Contains("save passwords in the browser"))
                {
                    SimulateTyping("It's safer to use a dedicated password manager than saving passwords in your browser.");
                }
                else if (input.Contains("reuse passwords"))
                {
                    SimulateTyping("Avoid reusing passwords across multiple sites. If one account is compromised, others could be at risk.");
                }
                else if (input.Contains("password manager"))
                {
                    SimulateTyping("Password managers help you generate and store strong, unique passwords securely for each website.");
                }
                else if (input.Contains("password"))
                {
                    SimulateTyping("Create strong passwords using at least 12 characters, mixing letters, numbers and symbols.");
                }

                //Phishing related questions

                else if (input.Contains("examples of phishing"))
                {
                    SimulateTyping("Examples include fake emails from your bank, messages claiming you've won a prize or urgent password reset requests.");
                }
                else if (input.Contains("how to avoid phishing"))
                {
                    SimulateTyping("Always check the sender's email, don’t click on suspicious links and use multi-factor authentication when possible.");
                }
                else if (input.Contains("report phishing"))
                {
                    SimulateTyping("You can report phishing by forwarding the message to your IT department or national cybercrime agency.");
                }
                else if (input.Contains("phishing"))
                {
                    SimulateTyping("Phishing is a cyber attack where attackers trick you into revealing personal information through fake messages or websites.");
                }

                //Safe browsing related questions
                else if (input.Contains("safe browsing"))
                {
                    SimulateTyping("Safe browsing means taking steps to protect yourself from malware, scams and harmful content while online.");
                }
                else if (input.Contains("how to browse safely") || input.Contains("browse safely"))
                {
                    SimulateTyping("Use updated browsers, ad-blockers, antivirus software, look for https:// in URL and avoid downloading unknown files.");
                }
                else if (input.Contains("https"))
                {
                    SimulateTyping("HTTPS means the site is secured with encryption. Always look for 'https://' in the URL before entering sensitive info.");
                }
                else if (input == "exit")
                {
                    SimulateTyping($"Goodbye {userName}! Hope I helped you!");
                    break;
                }
                else
                {
                    SimulateTyping("I didn't quite understand that. Could you rephrase?");
                }
            }
        }

        static void PlayVoiceGreeting()
        {
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    string filePath = "Audio/welcome.wav";
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.Play(); 

                    Thread.Sleep(7000); 
                }
                else
                {
                    Console.WriteLine("Voice greeting is not supported on this platform.");
                }
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Secure Bot: ");
            Console.ResetColor();

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }
    }
}



