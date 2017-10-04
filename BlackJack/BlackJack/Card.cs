using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{

     class Card
    {

        private string[] carddeck = new string[13];
       
        public void readFile()
        {
            StreamReader reader = new StreamReader("Card.txt");
            string line;
            int index = 0;

            while ((line = reader.ReadLine()) != null)
            {
                carddeck[index] = line; 
                
                index++;
            }

            
        }


        public int drawCard(string answer)
        {
            readFile();
            
            
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 11);
            
            int yourcard = 0;


            if (randomNumber == 1 && Player.sumOfCards == 0 )
            {
                Console.WriteLine("\nThe Card of that has been draw is " + carddeck[0]);
                yourcard = 11; 
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine("\nThe Card of that has been draw is " + carddeck[0]);
                yourcard = randomNumber;
                
            }
            else if (randomNumber >=2 && randomNumber != 10)
            {
                Console.WriteLine("\nThe Card of that has been draw is " + carddeck[randomNumber-1]);
                yourcard = randomNumber;

            }
            else
            {
                yourcard = randomNumber;
                int tilfeldig = rnd.Next(10, 13);
                Console.WriteLine("\nThe Card of that has been draw is " + carddeck[tilfeldig]);
            }
            
          
            return yourcard; 
        }

        
        

        public void checkResult(int player, int dealer)
        {
            if (dealer > player && !(dealer > 21))
            {
                Console.WriteLine("Sadly you lost. The dealer wins this round. You lost:  " + Player.placeBet + " $");

            }
            else if (dealer == player)
            {
                Console.WriteLine("Draw between you and the dealer");
            }
            else
            {
                int sum = Player.placeBet * 2; 
                
                Console.WriteLine("Congratulations You won this round, You won: " + sum + " $");
            }
            
            

        }


        
    }
}