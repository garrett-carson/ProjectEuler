﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace ProjectEuler.Lib {

    // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    // 
    // a2 + b2 = c2
    // For example, 32 + 42 = 9 + 16 = 25 = 52.
    // 
    // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    // Find the product abc.
    [Export(typeof(Problem))]
    public class Problem9 : Problem {

        public override string Run() {
            return ProductOfPythagoreanTripletWithSumOf(1000).ToString();
        }

        public int ProductOfPythagoreanTripletWithSumOf(int sum) {
            var triple = PythagoreanTriples().First(x => x.Item1 + x.Item2 + x.Item3 == sum);
            return triple.Item1 * triple.Item2 * triple.Item3;
        }

        private IEnumerable<Tuple<int, int, int>> PythagoreanTriples() {
            var c = 1;
            while (c > 0) {
                var b = 1;
                do {
                    var a = 1;
                    do {
                        if (_square(a) + _square(b) == _square(c)) {
                            yield return new Tuple<int, int, int>(a, b, c);
                        }
                        a++;
                    } while (a <= b);
                    b++;
                } while (b <= c);
                c++;
            }
        }

        private readonly Func<int, int> _square = Memoize<int, int>(x => (int)Math.Pow(x, 2));
        
        public static Func<TSource, TReturn> Memoize<TSource, TReturn>(Func<TSource, TReturn> func) {
            var cache = new Dictionary<TSource, TReturn>();
            return s => {
                if (!cache.ContainsKey(s)) {
                    cache[s] = func(s);
                }
                return cache[s];
            };
        }
    }
}
