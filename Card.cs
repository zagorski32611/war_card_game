using System;
using System.Collections.Generic;

namespace cardwar
{
    class Card
    {
        public int Rank;
        public string Suit;

        public Card(int rank, string suit)
        {
            Rank = rank;
            Suit = suit;

        }
    }
}