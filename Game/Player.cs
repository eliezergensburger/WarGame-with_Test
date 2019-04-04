using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNamespace
{
    public class Player
    {
        Queue<Card> queue = new Queue<Card>();
        public String Name { get; set; }

        public void addCard(Card card)
        {
            queue.Enqueue(card);
        }
        public bool loseout()
        {
            return queue.Count == 0;
        }
    }
}
