using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program { 

         
        static void Main(string[] args)
        {
           
            Console.WriteLine("WELCOME TO A GAME OF BLACKJACK\n");
            var card = new Card();
            var player = new Player();
            player.PlayerDrawCard();

            Console.WriteLine("Do you feel like playing another round? (yes/no): ");
            string answer = Console.ReadLine().ToLower();
            
            if (answer.Equals("yes"))
            {
                player.PlayerDrawCard();
                
            }
            else
            {
                Console.WriteLine("Thanks for Playing");
                Environment.Exit(0);
            }

        }
    }
}
