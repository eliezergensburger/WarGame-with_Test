using System;
using System.Collections.Generic;

namespace GameNamespace
{
    public class CardStock
    {
        static Random random = new Random();
        List<Card> cards;

        #region ctor

        public CardStock()
        {
            cards = new List<Card>();
            for (int i = Card.MINVAL; i <= Card.MAXVAL; i++)
            {
                cards.Add(new Card(i, "black"));
                cards.Add(new Card(i, "rEd"));
            }
            shuffle();
        }

        #endregion

        #region public methods

        public void shuffle()
        {
            int klaf1, klaf2;
            for (int i = 0; i < 1000; i++)
            {
               // for (int delay = 0; delay < 10000; delay++) { }
                klaf1 = random.Next(0, 26);
                do
                {
                    klaf2 = random.Next(0, 26);
                }
                while (klaf1 == klaf2);

                swap(cards,klaf1,klaf2);
            }
        }
         public Card this[int index]
        {
            get
            {
                if(index <0 || index > 25)
                {
                    return null;
                }
                return cards[index];
            }          
        }

        public Card this[string indexName]
        {
           get
            {
                Card card = null;
                foreach (Card item in cards)
                {
                    if (item.CardName==indexName)
                    {
                        card = item;
                        break;
                    }
                }
                return card;
            }
        }

        #endregion

        #region private methods

        private void swap(List<Card> cards, int k1, int k2)
        {
            Card temp = cards[k1];
            cards[k1] = cards[k2];
            cards[k2] = temp;
        }

        #endregion

        #region override
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}