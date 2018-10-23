using System.Linq;

namespace UnitTest
{
    public class DiceSet
    {
        private readonly Dice[] _dice;

        public DiceSet()
        {
            _dice = new[] {new Dice(), new Dice(), new Dice(), new Dice(), new Dice()};
        }

        public int[] GetValues()
        {
            return _dice.Select(d=>d.Number).ToArray();
        }
    }
}
