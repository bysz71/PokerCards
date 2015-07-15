using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerCards;

namespace UTPokerCards
{
    [TestClass]
    public class UTDeckOfCards
    {
        [TestMethod]
        public void TestCS()
        {
            var deck1 = new DeckOfCards();
            DeckOfCards deck2 = new DeckOfCards();
        }

        [TestMethod]
        public void TestShuffule()
        {
            var deck1 = new DeckOfCards();
            Card card;
            while(true)
            {
                card = deck1.DealCard();
                if (card != null)
                    Console.WriteLine(card.ToString());
                else
                    break;
            }
            Console.WriteLine("--------------");
            deck1.Shuffle();
            while (true)
            {
                card = deck1.DealCard();
                if (card != null)
                    Console.WriteLine(card.ToString());
                else
                    break;
            }
        }
    }
}
