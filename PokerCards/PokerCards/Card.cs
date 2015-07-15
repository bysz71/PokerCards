using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerCards
{
    public class Card
    {
        //face of card ("Ace","Deuce",...)
        private int _face;
        //suit of card ("Hearts","Diamonds",...)
        private int _suit;

        public Card(int face, int suit)
        {
            _face = face;
            _suit = suit;
        }

        public override string ToString()
        {
            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            return faces[_face] + " - " + suits[_suit];
        }
    }
}
