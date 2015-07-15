using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerCards;

namespace UTPokerCards
{
    [TestClass]
    public class UTCard
    {
        [TestMethod]
        public void TestCS()
        {
            var card1 = new Card(11, 2);
            Assert.AreEqual("Queen - Clubs", card1.ToString());
        }
    }
}
