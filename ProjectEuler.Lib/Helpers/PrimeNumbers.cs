using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Lib.Helpers {
    class PrimeNumbers {
        public static IEnumerable<ulong> UlongPrimes() {
            var memoized = new List<ulong>();
            var primes = PotentialUlongPrimes().Where(x => {
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
