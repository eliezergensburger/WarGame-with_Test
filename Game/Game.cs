using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamespace
{
    public class Game
    {
        public void start()
        {
            CardStock cardDeck = new CardStock();
          //  cardDeck.mixing();
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(cardDeck[i]);
            }
        }
    }
}
