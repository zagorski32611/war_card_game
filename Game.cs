using System;
using System.Collections.Generic;
using System.Linq;

namespace cardwar
{
    class Game
    {
        public Player War(Player player, Player computer)
        {
            var player_card = player.Deck.ElementAt(RandomIndexGen(0, player.Deck.Count));
            Console.WriteLine($"Player: {player_card.Rank} of {player_card.Suit}");
            
            var computer_card = computer.Deck.ElementAt(RandomIndexGen(0, computer.Deck.Count));
            Console.WriteLine($"Computer: {computer_card.Rank} of {computer_card.Suit}");


            if (player_card.Rank > computer_card.Rank)
            {
                Console.WriteLine("Player wins!");
                computer.Deck.Remove(computer_card);
                player.Deck.Add(computer_card);
                return player;
            }
            else if (player_card.Rank < computer_card.Rank)
            {
                Console.WriteLine("Computer Wins!");
                player.Deck.Remove(player_card);
                computer.Deck.Add(player_card);
                return computer;
            }
            else 
            {
                Console.WriteLine("It's a tie!");
                return player;
            }
            
        }

        public int RandomIndexGen(int x, int y)
        {
            Random rnd = new Random();
            int card_index = rnd.Next(x, y);
            return card_index;
        }


    }
}


/*
                var winning_card = player_card;
                var losing_card = computer_card;
                computer.Deck.Remove(winning_card);
                return player;


                        public Card Generate_Hand(Deck player_deck)
        {
            // randomly select card from deck. compare. remove / add
            Random rnd = new Random();
            int card_index = rnd.Next(1, 52);
            var chosen_card = player_deck
            return chosen_card;
        }

                 */