using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Card
    {
        private int dealercard;

        public Dealer()
        {
            dealercard = 0; 
        }

        public void DealerDrawCard(int playerscore)
        {
            
            Console.WriteLine("Dealer is about to draw a Card");
            int totalsum = 0;

            do
            {
                Console.WriteLine("The Dealer hits: ");
                dealercard = drawCard("hit");
                totalsum += dealercard;
                Console.WriteLine("The total sum for the dealer is: " + totalsum);
                if (totalsum > 16 && totalsum <= 21)
                {
                    checkResult(playerscore, totalsum);
                    break;
                }
                
                

            } while (totalsum < 21);


        }



    }
}
