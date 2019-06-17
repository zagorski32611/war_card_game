using System;
using System.Collections;
using System.Collections.Generic;

namespace cardwar
{
    class Deck
    {
        private Card[] cards;
        public List<Card> CreateDeck()
        {
            var deck = new List<Card>();
            cards = new Card[52];
            //var index = 0;

            string[] array = new[]{"Diamonds", "Spades", "Hearts", "Clubs"};
            
            foreach (string suit in array)
            {
                for (int rank = 1; rank <= 13; rank++)
                {
                    var card = new Card(rank: rank, suit: suit);
                    deck.Add(card);
                }

            }
            return deck;
        }
        public IEnumerator<Deck> GetEnumerator() => (IEnumerator<Deck>)this;
    }
}