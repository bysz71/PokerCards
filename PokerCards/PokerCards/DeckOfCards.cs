using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerCards
{
    public class DeckOfCards
    {
        private Card[] _deck;
        private int _currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random _randomNumbers;

        /// <summary>
        /// DeckOfCards constructor
        /// </summary>
        public DeckOfCards()
        {
            _deck = new Card[NUMBER_OF_CARDS];
            _currentCard = 0;
            _randomNumbers = new Random();

            for (int count = 0; count < _deck.Length; count++)
                _deck[count] = new Card(count % 13, count / 13);
        }

        /// <summary>
        /// Shuffle the deck of cards
        /// </summary>
        public void Shuffle()
        {
            _currentCard = 0;
            //change current card with a random card
            for (int changer = 0; changer < _deck.Length; changer++)
            {
                int changee = _randomNumbers.Next(NUMBER_OF_CARDS);
                Card temp = _deck[changer];
                _deck[changer] = _deck[changee];
                _deck[changee] = temp;
            }
        }

        /// <summary>
        /// Deal a card if not out of card
        /// </summary>
        /// <returns></returns>
        public Card DealCard()
        {
            if (_currentCard < _deck.Length)
                return _deck[_currentCard++];
            else
                return null;
        }
    }
}
