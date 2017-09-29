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

         //TODO 1. FIX ARRAY CLASS CARD, 2. GO THROUGH IF EVERYTHING IS CORRECT WITH THE DEALERS HAND, 3. IMPLEMENT PLACEBETS.
        static void Main(string[] args)
        {
            var card = new Card();
            var player = new Player();
            card.readFile();
            player.PlayerDrawCard();
            Console.ReadKey(true); 


        }
    }
}
