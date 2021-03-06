﻿using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Lib {

    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    // 
    // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // 
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    [Export(typeof(Problem))]
    public class Problem2 : Problem {
        public override string Run() {
            return SumEvenFibonacciRange(4000000).ToString();
        }

        public BigInteger SumEvenFibonacciRange(int max) {
            return Fibonacci().TakeWhile(x => x <= max).Where(x => x % 2 == 0).Aggregate((x, y) => x + y);
        }

        private IEnumerable<BigInteger> Fibonacci() {
            BigInteger previous = 1;
            BigInteger current = 1;
            while (true) {
                yield return current;
                var tmp = current;
                current += previous;
                previous = tmp;
            }
        } 
    }
}
