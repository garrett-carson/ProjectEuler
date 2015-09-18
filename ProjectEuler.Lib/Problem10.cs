using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using ProjectEuler.Lib.Helpers;

namespace ProjectEuler.Lib {

    // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    // 
    // Find the sum of all the primes below two million.
    [Export(typeof(Problem))]
    public class Problem10 : Problem {
        public override string Run() {
            return SumOfPrimesBelow(2000000).ToString();
        }

        public ulong SumOfPrimesBelow(int max) {
            return PrimeNumbers.UlongPrimes().TakeWhile(x => x < (ulong)max).Aggregate((x, y) => x + y);
        }
    }
}
