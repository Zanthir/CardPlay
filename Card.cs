using System;

namespace HelloWorld {
    public class Card : IComparable {
        public readonly Rank Rank;
        public readonly Suit Suit;
        public Card(Rank rank, Suit suit) {
            Rank = rank;
            Suit = suit;
        }

        // Implement IComparable CompareTo to provide default sort order.
        int IComparable.CompareTo(object obj)
        {
            var card = (Card) obj;
            
            //Compare suit first
            if(this.Suit < card.Suit)
            {
                return -1; //This card preceeds the other card.
            }
            if(this.Suit > card.Suit)
            {
                return 1; //This card comes after the other card.
            }

            //Suits are equal. Compare ranks.
            if(this.Rank < card.Rank)
            {
                return -1; //Same suit but lower rank than the other card.
            }
            if(this.Rank > card.Rank)
            {
                return 1; //Same suit but higher rank than the other card.
            }

            //Cards are equal. This shouldn't happen in a 52 card deck, but maybe we are using a double deck or something.
            return 0;
        }
    }
}