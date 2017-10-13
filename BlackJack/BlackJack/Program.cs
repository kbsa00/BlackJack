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
            bool play = true;
         
            
        
            while (play)  {     
            var card = new Card();
            var player = new Player();
            player.PlayerDrawCard();
            string answer;    
            Console.WriteLine("Do you want to play another round, Please input (yes/no)");
            answer = Console.ReadLine().ToLower();
                
              if (answer.Equals("yes")) {
                    Console.WriteLine("\n\nDealer: SWEET, You want to play another round! :D ");
                }
               else
                {
                    break;
                }
            }
            
            Console.WriteLine("\n\nThanks for playing :D See you next time");
            

        }
    }
}
