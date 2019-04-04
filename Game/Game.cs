using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamespace
{
    public class Game
    {
        private Player player1;
        private Player player2;
        private CardStock cardDeck = new CardStock();

        public Game()
        {

        }
        public Game(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;

            distribute(player1, player2);
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
