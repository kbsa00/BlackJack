using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 
namespace BlackJack
{
    class Dealer : Card
    {
        private int dealercard;
        public static int totalsum; 

        public Dealer()
        {
            dealercard = 0;
            totalsum = 0; 
        }

        public void DealerDrawCard(int playerscore)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDealer is about to draw a Card");
          

            do
            {
                Console.WriteLine("The Dealer hits: ");
                for(int i = 0;i < 4;i++)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                }
                Console.Write("\n");
                dealercard = drawCard("hit");
                totalsum += dealercard;
                Console.WriteLine("\nThe total sum for the dealer is: " + totalsum);
                
                if (totalsum > 16)
                {
                    checkResult(playerscore, totalsum);
                    break;
                }
                
               
                
            } while (totalsum < 21);
 
            
        }



    }
}
