using System;
using System.Linq;
using System.Media;
using System.Threading;

class CybersecurityChatbot
{
    // Task 1: Play Greeting Audio File
    static void PlayGreeting()
    {
        string greetingFilePath = "Audio/Nature.wav";  // Path to the greeting WAV file
        try
        {
            using (SoundPlayer player = new SoundPlayer(greetingFilePath))
            {
                player.PlaySync();  // Plays the greeting audio file when the chatbot starts
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error playing greeting: {ex.Message}");
            Console.ResetColor();
        }
    }

    // Task 2: Display ASCII Art Logo
    static void DisplayAsciiArtLogo()
    {
        // Setting up the colors for the header
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("========================================================================================================================");
        Console.WriteLine("                                Welcome Join Us and become a Cybersecurity Guru                                         ");
        Console.WriteLine("========================================================================================================================");

        // Setting the color for the ASCII Art
        Console.ForegroundColor = ConsoleColor.Cyan;

       
            // Setting up the colors for the header
            Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();

            // Setting the color for the ASCII Art
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Defining the ASCII art in an array of strings
            string[] asciiArt = new string[]
            {
        "================================= CYBERSECURITY BOT =================================",
        "   _____",
        "  /     \\",
        " |  O O  |    _______",
        " |   ^   |   /       \\",
        " |  '-'  |  |   SHLD  |",
        "  \\_____/   \\_________/",
        "   | | | |",
        "  /  | |  \\",
        " /___|_|___\\",
        "  [=======]",
        "   \\     /",
        "    \\___/"
            };


            // Get the width of the console window
            int consoleWidth = Console.WindowWidth;

            // Find the longest line in the ASCII art for consistent centering
            int maxLength = asciiArt.Max(line => line.Length);

            // Loop through each line and center it
            foreach (var line in asciiArt)
            {
                // Calculate the number of spaces needed to center the line
                int padding = (consoleWidth - maxLength) / 2;

                // Write the line with padding before it
                Console.WriteLine(new string(' ', padding) + line);
            }

            // Resetting to default color after drawing the logo
            Console.ResetColor();
        }


        // Task 3: Type Effect for Text Display
        static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }

    // Task 4: Validate User Input
    static bool ValidateInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input cannot be empty. Please ask something related to cybersecurity.");
            Console.ResetColor();
            return false;
        }
        return true;
    }

    // Task 5: Display Available Topics
    static void DisplayAvailableTopics()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("Available Topics/Questions to Ask:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("1. Password Security");
        Console.WriteLine("2. Phishing");
        Console.WriteLine("3. Safe Browsing");
        Console.WriteLine("4. Identity Theft");
        Console.WriteLine("5. Firewall");
        Console.WriteLine("6. VPNs (Virtual Private Networks)");
        Console.WriteLine("7. Data Breaches");
        Console.WriteLine("8. Encryption");
        Console.WriteLine("9. Ransomware");
        Console.WriteLine("10. Spyware");
        Console.WriteLine("11. Malware");
        Console.WriteLine("12. Password Managers");
        Console.WriteLine("13. Internet of Things (IoT)");
        Console.WriteLine("------------------------------------");
        Console.ResetColor();
    }

    // Task 6: Handle User's Input and Respond
    public static void HandleUserInput(string userInput, string userName)
    {
        userInput = userInput.ToLower();

        // Handling common questions
        if (userInput.Contains("how are you") || userInput.Contains("how are you doing"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bot: I'm just a chatbot, {userName}, but I'm here to help you with cybersecurity!");
        }
        else if (userInput.Contains("what's your purpose") || userInput.Contains("what is your purpose"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bot: I am designed to educate and assist with cybersecurity topics, helping users stay safe online.");
        }
        else if (userInput.Contains("what can i ask you about") || userInput.Contains("what can I ask you"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bot: You can ask me about various cybersecurity topics like passwords, phishing, malware, and much more. Type Consult for the full list of topics.");
            DisplayAvailableTopics();
        }
        else if (userInput.Contains("consult"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bot: Write Consult if you want to ask questions.");
            DisplayAvailableTopics();
        }
        else if (userInput.Contains("password"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: A password is a string of characters used to authenticate a user to a system. It helps prevent unauthorized access to personal or sensitive information.");
                Console.WriteLine("Example: A common password is '123456', but this is weak and easy to guess.");
            }
            else if (userInput.Contains("how to be safe") || userInput.Contains("prevent") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: To stay safe, use strong passwords with a mix of uppercase, lowercase, numbers, and symbols. Avoid using easily guessable words like your name or birthdate.");
                Console.WriteLine("Use a password manager to store complex passwords securely.");
            }
        }
        else if (userInput.Contains("phishing"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Phishing is a cyber attack where hackers trick individuals into providing personal information by pretending to be a trusted entity.");
                Console.WriteLine("Example: An email that looks like it's from your bank asking you to verify your account is likely a phishing attempt.");
            }
            else if (userInput.Contains("how to notice") || userInput.Contains("how to be safe") || userInput.Contains("prevent"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Be cautious of unexpected emails, check the sender's email address, and never click on suspicious links or attachments.");
                Console.WriteLine("Enable two-factor authentication (2FA) for extra security.");
            }
        }
        else if (userInput.Contains("safe browsing"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Safe browsing refers to practices that help users avoid malicious websites and online threats.");
                Console.WriteLine("Example: Using an up-to-date browser with security features helps protect against malicious sites.");
            }
            else if (userInput.Contains("how to be safe") || userInput.Contains("prevent") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Always check URLs before clicking, avoid public Wi-Fi for sensitive activities, and use security extensions in your browser.");
                Console.WriteLine("Use VPNs to add a layer of security when browsing online.");
            }
        }
        else if (userInput.Contains("identity theft"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Identity theft occurs when someone illegally acquires and uses another person's personal information, usually for financial gain.");
                Console.WriteLine("Example: Using someone's social security number to open a bank account without their permission.");
            }
            else if (userInput.Contains("how to prevent") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: To protect yourself, avoid sharing personal information online, use strong passwords, and monitor your financial statements regularly.");
            }
        }
        else if (userInput.Contains("firewall"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: A firewall is a network security system that monitors and controls incoming and outgoing network traffic based on predetermined security rules.");
                Console.WriteLine("Example: A firewall can block unwanted traffic from reaching your computer or network.");
            }
            else if (userInput.Contains("how to configure") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Ensure your firewall is enabled, configure it to block dangerous ports, and regularly update it to address vulnerabilities.");
            }
        }
        else if (userInput.Contains("vpn"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: A VPN (Virtual Private Network) extends a private network across a public network, allowing you to send and receive data as if your device was directly connected to the private network.");
                Console.WriteLine("Example: A VPN encrypts your internet connection, protecting your online activity.");
            }
            else if (userInput.Contains("how to use") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Use a reputable VPN service to ensure your internet connection is encrypted and your browsing activity remains private.");
            }
        }
        else if (userInput.Contains("data breaches"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: A data breach occurs when unauthorized individuals gain access to sensitive or confidential information, often for malicious purposes.");
                Console.WriteLine("Example: A company’s database being hacked and customer information being exposed.");
            }
            else if (userInput.Contains("how to prevent") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Use strong passwords, encrypt sensitive data, and implement multi-factor authentication to reduce the risk of a data breach.");
            }
        }
        else if (userInput.Contains("encryption"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Encryption is the process of converting information into a code to prevent unauthorized access.");
                Console.WriteLine("Example: When you use HTTPS, your data is encrypted while being transmitted over the internet.");
            }
            else if (userInput.Contains("how to encrypt") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Use encryption tools like BitLocker or file-level encryption to protect your data. Always encrypt sensitive information before sharing it.");
            }
        }
        else if (userInput.Contains("ransomware"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Ransomware is malicious software that encrypts a victim's data and demands a ransom for its release.");
                Console.WriteLine("Example: A pop-up demanding money in exchange for decrypting files.");
            }
            else if (userInput.Contains("how to prevent") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Keep your software updated, use antivirus programs, and avoid clicking on suspicious links to protect yourself from ransomware.");
            }
        }
        else if (userInput.Contains("spyware"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Spyware is software that secretly monitors your computer activity, often stealing sensitive information.");
                Console.WriteLine("Example: A program that tracks your keystrokes to steal passwords.");
            }
            else if (userInput.Contains("how to prevent") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Use anti-spyware tools, avoid downloading files from untrusted sources, and regularly update your software.");
            }
        }
        else if (userInput.Contains("malware"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Malware is any software intentionally designed to cause damage or harm to a system.");
                Console.WriteLine("Example: Viruses, worms, and trojans are all types of malware.");
            }
            else if (userInput.Contains("how to prevent") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Use antivirus software, avoid downloading files from untrusted sources, and regularly back up your data.");
            }
        }
        else if (userInput.Contains("iot"))
        {
            if (userInput.Contains("define") || userInput.Contains("what is") || userInput.Contains("explain"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: The Internet of Things (IoT) refers to the connection of everyday objects to the internet, enabling them to send and receive data.");
                Console.WriteLine("Example: Smart thermostats, smartwatches, and connected home appliances are examples of IoT devices.");
            }
            else if (userInput.Contains("how to secure") || userInput.Contains("tips"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Secure your IoT devices by changing default passwords, regularly updating firmware, and isolating IoT devices on a separate network.");
            }
        }
        else if (!string.IsNullOrWhiteSpace(userInput))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Bot: I didn't quite understand that. Could you rephrase?");
        }
    }

    static void Main(string[] args)
    {
        // You can customize this to prompt for user input
        DisplayAsciiArtLogo();
        PlayGreeting();
        Console.WriteLine("Hello there enter your name.");
        String userName=Console.ReadLine();
        TypeEffect("Hello "+userName+" welcome to the Cybersecurity Chatbot. Write Consult if you want to ask questions.");
        Console.WriteLine("Type 'exit' to exit the program.");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{userName}: ");
            Console.ResetColor();
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                break;
            }

            if (ValidateInput(userInput))
            {
                HandleUserInput(userInput, userName);
            }
        }
    }
}
