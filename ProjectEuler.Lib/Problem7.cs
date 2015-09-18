using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using ProjectEuler.Lib.Helpers;

namespace ProjectEuler.Lib {

    // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    // 
    // What is the 10 001st prime number?
    [Export(typeof(Problem))]
    public class Problem7 : Problem {
        public override string Run() {
            return NthUlongPrime(10001).ToString();
        }

        public ulong NthUlongPrime(int index) {
            return PrimeNumbers.UlongPrimes().ElementAt(index - 1);
        }
    }
}
