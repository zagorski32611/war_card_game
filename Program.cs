using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace cardwar
{
    class Program
    {
        Deck deck = new Deck();
        Player player = new Player();

        Game game = new Game();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.StartGame();            
        }

        public List<Card> GetNewDeck()
        {
            
            var cards = deck.CreateDeck();
            foreach(var card in cards)
            {
                Console.WriteLine("the {0} of {1}", card.Rank, card.Suit);
            }
            return cards;
        }

        public Player GetNewPlayer(string name)
        {
            var current_deck = deck.CreateDeck();
            var current_player = player.CreateNewPlayer(name, current_deck);
            
            player.Name = name;
            player.Deck = current_deck;
            
            return player;
        }


        public Player StartGame()
        {
            var computer = GetNewPlayer("Computer");
            var player = GetNewPlayer("Joe");
            var winning_card = game.War(player, computer);
            
            while(player.Deck.Count > 0 || computer.Deck.Count > 0)
            {
                game.War(player, computer);
            }
            if(player.Deck.Count == 0)
            {
                return computer;
            }
            else
            {
                return player;
            }
        }
    
    }
}
