using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

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
            return UlongPrimes().ElementAt(index - 1);
        }

        private static IEnumerable<ulong> UlongPrimes() {
            var memoized = new List<ulong>();
            var primes = PotentialUlongPrimes()
                .Where(x => {
                    double sqrt = Math.Sqrt(x);
                    return memoized
                        .TakeWhile(y => y <= sqrt)
                        .All(y => x % y != 0);
                });
            foreach (var prime in primes) {
                yield return prime;
                memoized.Add(prime);
            }
        }

        private static IEnumerable<ulong> PotentialUlongPrimes() {
            yield return 2;
            yield return 3;
            ulong k = 1;
            while (k > 0) {
                yield return 6 * k - 1;
                yield return 6 * k + 1;
                k++;
            }
        }
    }
}
