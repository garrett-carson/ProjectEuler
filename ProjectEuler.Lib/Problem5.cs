using System;
using System.ComponentModel.Composition;
using System.Linq;

namespace ProjectEuler.Lib {

    // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    // 
    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    [Export(typeof(Problem))]
    public class Problem5 : Problem {
        public override string Run() {
            return LeastCommonMultipleFromRange(20).ToString();
        }

        public int LeastCommonMultipleFromRange(int max) {
            return Enumerable.Range(1, max - 1).Aggregate(LeastCommonMultiple);
        }

        private int LeastCommonMultiple(int a, int b) {
            return Math.Abs(a * b) / GreatestCommonDenominator(a, b);
        }

        private int GreatestCommonDenominator(int a, int b) {
            return b == 0 ? a : GreatestCommonDenominator(b, a % b);
        }
    }
}
