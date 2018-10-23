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

        public DiceSet(int v1, int v2, int v3, int v4, int v5)
        {
            _dice = new[] { new Dice(v1), new Dice(v2), new Dice(v3), new Dice(v4), new Dice(v5) };
        }

        public int[] GetValues()
        {
            return _dice.Select(d=>d.Number).ToArray();
        }

        public int GetPointsAsOnePair()
        {
            return 0;
        }
    }
}
