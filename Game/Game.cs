using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamespace
{
    public class Game
    {
        private Player[] players = new Player[2];
        private CardStock cardDeck = new CardStock();

         public Game(params Player[] players  )
        {
            for (int i = 0; i < players.Length; i++)
            {
                this.players[i] = players[i];
            }
 
            distribute(players);
        }

        public void distribute(params Player[] players)
        {
            int i = 0;
            while (i < CardStock.NUM_CARDS)
            {
                foreach (Player p in players)
                {
                    p.addCard(cardDeck[i]);
                }
            }
        }
   
        public void start()
        {
            //  cardDeck.mixing();
            for (int i = 0; i < CardStock.NUM_CARDS; i++)
            {
                Console.WriteLine(cardDeck[i]);
            }
        }
    }
}
