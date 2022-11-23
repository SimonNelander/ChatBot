using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool UserContinue = true;
            while (UserContinue == true)
            {
                Console.WriteLine("Välkommen till nätverks botten\n Vad är det som inte fungerar?");
                Console.WriteLine("Skriv något av deassa problem: \ninternet \nlogga in \ninget");
                string userInput = Console.ReadLine();

             void forgotpassword()
             {
                Console.WriteLine("Skriv antigen ja eller nej");
                string YesOrNo = Console.ReadLine();
                if (YesOrNo == "ja")
                {
                    Console.WriteLine("Då ska jag hjälpa dig");
                }
                else if (YesOrNo == "nej")
                {
                    Console.WriteLine("Då måste du ha glömt användarnamnet");
                }
                else
                {
                    Console.WriteLine("No help for u then");
                }
             }
             void NetworkProblem()
             {
                Console.WriteLine("Skriv ja eller nej");
                string YesorNo = Console.ReadLine();
                if (YesorNo == "ja")
                {
                    Console.WriteLine("Då behöver du hjälp");
                }
             }

             switch (userInput)
             {
                case "internet":
                    Console.WriteLine("Jaha så du har problem med internet");
                    NetworkProblem();
                    break;

                case "logga in":
                    Console.WriteLine("synd, har du glömt ditt lösenord");
                    forgotpassword();
                    break;

                case "inget":
                    Console.WriteLine("Vad bra, i sånan fall ha en trevlig dag");
                    Console.WriteLine("Tryck på ENTER för att avsluta");
                    break;
             }
            }
            Console.Read();


        }
    }
}
