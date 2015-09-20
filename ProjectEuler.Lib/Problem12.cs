﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using ProjectEuler.Lib.Helpers;

namespace ProjectEuler.Lib {

    // The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
    // 
    // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    // 
    // Let us list the factors of the first seven triangle numbers:
    // 
    //  1: 1
    //  3: 1,3
    //  6: 1,2,3,6
    // 10: 1,2,5,10
    // 15: 1,3,5,15
    // 21: 1,3,7,21
    // 28: 1,2,4,7,14,28
    // We can see that 28 is the first triangle number to have over five divisors.
    // 
    // What is the value of the first triangle number to have over five hundred divisors?
    [Export(typeof(Problem))]
    public class Problem12 : Problem {
        public override string Run() {
            return TriangleNumberWithMoreThanXNumberOfDivisors(500).ToString();
        }

        public int TriangleNumberWithMoreThanXNumberOfDivisors(int divisors) {
            return triangleNumbers().First(x => numberOfDivisors(x) > divisors);
        }

        private static IEnumerable<int> triangleNumbers() {
            var i = 1;
            var accumulator = 0;
            while (true) {
                accumulator += i++;
                yield return accumulator;
            }
        }

        private static int numberOfDivisors(int number) {
            int numberOfDivisors = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++) {
                if (number % i == 0) {
                    numberOfDivisors += 2;
                }
            }

            //Correction if the number is a perfect square
            if (sqrt * sqrt == number) {
                numberOfDivisors--;
            }

            return numberOfDivisors;
        }
    }
}