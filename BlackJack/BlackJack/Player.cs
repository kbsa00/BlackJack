using System;

namespace BlackJack
{
    public class Player : Card
    {
        private int sumOfCards;
        private string answer;
        private int placeBet; 

        public Player()
        {
            sumOfCards = 0;
            placeBet = 0; 
        }


        public void PlayerDrawCard()
        {
            var dealer = new Dealer();
            
            Console.WriteLine("Place your bets: ");
            placeBet = Console.Read();

            int num = drawCard("hit"); 
            Console.WriteLine("Your first card is " + num);
            sumOfCards += num;

            Console.WriteLine("Do you want to hit, Write Hit to recive another card or Stand with the cards you have");
            answer = Console.ReadLine().ToLower();
            Console.WriteLine(answer);

            while (answer.Equals("hit") && sumOfCards <= 21)
            {
                num = drawCard(answer);
                sumOfCards += num;

                if (sumOfCards > 21)
                {
                    Console.WriteLine( "Total sum: "+ sumOfCards + " Sorry that's a Bust for you. Dealer wins!");
                    break;
                }

                Console.WriteLine("Do you want to hit again or do you want to stand with your total sum: " + sumOfCards);
                answer = Console.ReadLine().ToLower(); 
                if (answer.Equals("stand"))
                {
                    dealer.DealerDrawCard(sumOfCards);   
                    break;
                }
            }

           
            
        }

    }
}