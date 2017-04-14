using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWorld {
    public class Deck {
        public List<Card> Cards;

        public Deck(){
            var ranks = Enum.GetValues(typeof(Rank)).Cast<Rank>();
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();

            Cards = new List<Card>();

            foreach(var suit in suits){
                foreach(var rank in ranks){
                    Cards.Add(new Card(rank, suit));
                }
            }
        }

        public Deck Shuffle() {
            var random = new Random();
            var shuffledCards = new List<Card>();
            var cardsInDeck = Cards.Count;

            for(int i = 0; i < cardsInDeck; i++){
                var randomNumber = random.Next(0, Cards.Count); // Starts as 0-51, ends with just 0.
                var pickedCard = Cards[randomNumber];
                Cards.Remove(pickedCard);
                shuffledCards.Add(pickedCard);
            }
            Console.WriteLine();

            Cards = shuffledCards;

            return this;
        }

        public Deck Sort() {
            Cards.Sort();
            return this;
        }

        public void PrintCards() {
            foreach(var card in Cards)
            {
                Console.WriteLine($"{card.Rank.ToString()} of {card.Suit.ToString()}");
            }
            Console.WriteLine();
        }
    }
}