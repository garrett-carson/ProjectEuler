using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Lib.Helpers {
    class PrimeFactors {
        public static IEnumerable<ulong> FactorsOf(ulong number) {
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
