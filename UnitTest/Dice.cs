using System;

namespace UnitTest
{
    public class Dice
    {
        public int Number { get; private set; }

        public void Roll()
        {
            Number = YatzyRandom.Instance.GetNumber();
        }
    }
}
