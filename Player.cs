using System;
using System.Collections;
using System.Collections.Generic;

namespace cardwar
{
    class Player
    {
        public string Name;
        public List<Card> Deck;
        public string CreateNewPlayer(string name, List<Card> deck)
        {
            Name = name;
            Deck = deck;   
            return name;
        }
    }
}