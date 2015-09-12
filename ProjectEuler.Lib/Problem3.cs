using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Lib {

    // The prime factors of 13195 are 5, 7, 13 and 29.
    // 
    // What is the largest prime factor of the number 600851475143 ?
    [Export(typeof(Problem))]
    public class Problem3 : Problem {
        public override string Run() {
            return LargestPrimeFactor(600851475143).ToString();
        }

        public ulong LargestPrimeFactor(ulong number) {
            return PrimeFactors(number).Max();
        }

        private static IEnumerable<ulong> PrimeFactors(ulong number) {
            ulong a, b;
            a = number;
            for (b = 2; a > 1; b++) {
                if (a % b == 0) {
                    while (a % b == 0) {
                        a /= b;
                    }
                    yield return b;
                }
            }
        }
    }
}
