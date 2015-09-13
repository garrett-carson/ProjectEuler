using System;
using System.ComponentModel.Composition;
using System.Linq;

namespace ProjectEuler.Lib {

    // The sum of the squares of the first ten natural numbers is,
    // 12 + 22 + ... + 102 = 385
    // 
    // The square of the sum of the first ten natural numbers is,
    // (1 + 2 + ... + 10)2 = 552 = 3025
    // 
    // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    // 
    // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    [Export(typeof(Problem))]
    public class Problem6 : Problem {
        public override string Run() {
            return DiffBetweenSumOfSquaresAndSquareOfSums(100).ToString();
        }

        public int DiffBetweenSumOfSquaresAndSquareOfSums(int max) {
            return Math.Abs(SumOfTheSquares(max) - SquareOfTheSum(max));
        }

        private static int SquareOfTheSum(int max) {
            var sum = Enumerable.Range(1, max).Sum();
            return sum*sum;
        }

        private static int SumOfTheSquares(int max) {
            return Enumerable.Range(1, max).Select(x => x*x).Sum();
        }
    }
}
