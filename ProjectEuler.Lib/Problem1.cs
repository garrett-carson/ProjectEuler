﻿using System.ComponentModel.Composition;
using System.Linq;

namespace ProjectEuler.Lib {
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // 
    // Find the sum of all the multiples of 3 or 5 below 1000.
    [Export(typeof(ProblemBase))]
    public class Problem1 : ProblemBase {
        public int Run(int max) {
            return Enumerable.Range(0, max).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }

        public override string Answer => Run(1000).ToString();
    }
}
