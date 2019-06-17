using System;
using System.Collections.Generic;
using System.Linq;

namespace cardwar
{
    class Game
    {
        public Card Generate_Hand(Player player_deck)
        {
            // randomly select card from deck. compare. remove / add
            Random rnd = new Random();
            int card_index = rnd.Next(1, 52);
            var chosen_card = player_deck.Deck[card_index];
            return chosen_card;
        }

        public Player War(Player player_chosen_card, Player computer_chosen_card)
        {
           
            Game g = new Game();
            var player_card = g.Generate_Hand(player_chosen_card);
            var computer_card = g.Generate_Hand(computer_chosen_card);
            
            Console.WriteLine(player_card);
            Console.WriteLine(computer_card);
                
            if(player_card.Rank > computer_card.Rank)
            {
                Console.WriteLine("Player wins!");
                var winning_card = player_card;
                computer_chosen_card.Deck.Remove(winning_card);
                return player_chosen_card;
                
            }
            else if (player_card.Rank < computer_card.Rank)
            {
                Console.WriteLine("Computer Wins!");
                // remove player card and give to computer
                var winning_card = computer_card;
                player_chosen_card.Deck.Remove(winning_card);
                return computer_chosen_card;
            }
            else 
            {
                Console.WriteLine("It's a tie!");
                return player_chosen_card;
            }
            
        }
    }
}