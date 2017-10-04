using System;

namespace BlackJack
{
    class Player : Card
    {
        public static int sumOfCards;
        private string answer;
        public static int placeBet; 

        public Player()
        {
            sumOfCards = 0;
            placeBet = 0; 
        }


        public void PlayerDrawCard()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            var dealer = new Dealer();
            
            Console.Write("Place your bets: ");
            placeBet = Convert.ToInt32(Console.ReadLine());
            

            int num = drawCard("hit");

            Console.WriteLine("Your first card is " + num);
            sumOfCards += num;

            Console.WriteLine("Do you want to hit, Write Hit to recive another card or Stand with the cards you have");
            answer = Console.ReadLine().ToLower();

            if (answer.Equals("stand"))
            {
               dealer.DealerDrawCard(sumOfCards);
            }
            else if (!(answer.Equals("hit")))
            {
                Console.WriteLine("You wrote something else, Please write hit or stand");
                answer = Console.ReadLine().ToLower(); 
            }
             
          
            
            
            while (answer.Equals("hit") && sumOfCards <= 21)
            {
                num = drawCard(answer);
                sumOfCards += num;
                
                Console.WriteLine("Do you want to hit again or do you want to stand with your total sum: " + sumOfCards);
                if (sumOfCards > 21)                                                                             
                {                                                                                                
                    Console.WriteLine( "Total sum: "+ sumOfCards + " Sorry that's a Bust for you. Dealer wins! Lost: " + placeBet + "$");
                    break;
                                                                                                  
                }  
                answer = Console.ReadLine().ToLower();
                
                if (answer.Equals("stand") || sumOfCards == 21)
                {
                    dealer.DealerDrawCard(sumOfCards);   
                    break;
                }
               
            }
            
         }
           
        }
    }
  
  
 