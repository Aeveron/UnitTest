using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace YatzyTest
{
    [TestClass]
    public class DiceSetTest
    {
        [TestMethod]
        public void TestGetValues()
        {
            var diceSet = new DiceSet();
            var values = diceSet.GetValues();
            Assert.AreEqual(5, values.Length);
        }
    }
}
