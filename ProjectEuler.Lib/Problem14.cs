using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Numerics;
using ProjectEuler.Lib.Helpers;

namespace ProjectEuler.Lib {

    // The following iterative sequence is defined for the set of positive integers:
    // 
    // n → n/2 (n is even)
    // n → 3n + 1 (n is odd)
    // 
    // Using the rule above and starting with 13, we generate the following sequence:
    // 
    // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    // 
    // Which starting number, under one million, produces the longest chain?
    // 
    // NOTE: Once the chain starts the terms are allowed to go above one million.
    [Export(typeof(Problem))]
    public class Problem14 : Problem {

        public override string Run() {
            return LongestCollatzSequenceInRange(1000000).ToString();
        }

        private int LongestCollatzSequenceInRange(int max) {
            return Enumerable.Range(1, max - 1).OrderByDescending(x => CollatzSequence(x).Count()).First();
        }

        public IEnumerable<ulong> CollatzSequence(int start) {
            ulong next = (ulong)start;
            yield return next;
            while (next > 1) {
                next = nextColatz(next);
                yield return next;
            }
        }

        private ulong nextColatz(ulong next) {
            if (next % 2 == 0) {
                return next / 2;
            } else {
                return 3 * next + 1;
            }
        }
    }
}
