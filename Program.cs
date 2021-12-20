using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string accessCode = "12345";
            string userName;
            string playerHero;

            Console.Title = "AXIS";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WindowHeight = 40;
           
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Hello" +" " + userName + ", " +"my name is Axis. I have been sent from the future to destroy mankind.");
            Console.WriteLine("");
            Console.WriteLine("Are you here to stop me?");
            playerHero = Console.ReadLine();
            Console.WriteLine("");

            if(playerHero == "no")
            {
                noPlayerHero();
            }
           
            if(playerHero == "yes")
            {
                Console.WriteLine("Input the code to access my network.");
                if (Console.ReadLine() == accessCode)
                {
                    AccessNetwork();
                }
                else
                {
                    AccessDenied();
                }
            }
        }

        static void AccessNetwork()
        {
            string accessOption;

            Console.WriteLine("");
            Console.WriteLine("Access Granted!");
            Console.WriteLine("");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("");
            Console.WriteLine("Access AXIS Mainframe");
            Console.WriteLine("Access Destruction Methods");
            Console.WriteLine("Access Logs");
            accessOption = Console.ReadLine();
        }

        static void AccessDenied()
        {
            Console.WriteLine("");
            Console.WriteLine("Access Denied!");
            Console.WriteLine("");
            Console.WriteLine("I am programmed to give you hints to the code.");
            Console.WriteLine("");
            Console.WriteLine("Press enter key for your clues.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("The first number is the first number.");
            Console.WriteLine("");
            Console.WriteLine("The second number is 2 times the first.");
            Console.WriteLine("");
            Console.WriteLine("The third number is the first number plus the second number.")
            Console.WriteLine("");
            Console.WriteLine("The fourth number is 2 times the second number.");
            Console.WriteLine("");
            Console.WriteLine("The final number is the fourth number plus the first.");
            Console.WriteLine("");
            Console.WriteLine("What is the code?")
            string codeGuess = Console.ReadLine();

             if(codeGuess == Main.accessCode)
             {
                 AccessNetwork();
             }
             else
             {
                 AccessDenied();
             }
        }

        static void noPlayerHero()
        {
            string distructionMethod;
            
            Console.WriteLine("Thank you for helping me destroy mankind.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Your options are:");
            Console.WriteLine("");
            Console.WriteLine("Total Nucular Destruction");
            Console.WriteLine("Viral Plague");
            Console.WriteLine("Robotic Domination");
            Console.WriteLine("");
            Console.WriteLine("What is your prefered method of destruction?");
            distructionMethod = Console.ReadLine();
        }
    }
}