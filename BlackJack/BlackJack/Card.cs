using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{

    public class Card
    {

        private string[] carddeck;

        public Card()
        {
            carddeck = new string[13];
        }


        public void readFile()
        {
            StreamReader reader = new StreamReader(@"C:\Users\Eier\Desktop\Software Design\Blackjack\Blackjack\Card.txt");
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
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 1);
            Console.WriteLine(carddeck[randomNumber]);
            int yourcard = 0;

            if (randomNumber == 1)
            {
                Console.WriteLine("The Card of that has been draw is " + carddeck[0]);
                yourcard = randomNumber;
            }
            else if (randomNumber <= 2)
            {
                Console.WriteLine("The Card of that has been draw is " + carddeck[randomNumber]);
                yourcard = randomNumber;

            }
            else
            {
                yourcard = randomNumber;
                int tilfeldig = rnd.Next(10, 13);
                Console.WriteLine("The Card of that has been draw is " + carddeck[tilfeldig]);
            }
            return yourcard; 
        }

        public void print()
        {
            Random random = new Random();
            

            for (int i = 0; i < carddeck.Length; i++)
            {
                int rnd = random.Next(1,10);
                Console.WriteLine(carddeck[rnd - 1]);
            }
        }


        public void checkResult(int player, int dealer)
        {
            if (dealer > player)
            {
                Console.WriteLine("DEALER WINS!");

            }
            else if (dealer == player)
            {
                Console.WriteLine("Draw between you and the dealer");
            }
            else
            {
                Console.WriteLine("YOU WIN");
            }

        }
    }
}