using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Lib {

    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // 
    // Find the largest palindrome made from the product of two 3-digit numbers.
    [Export(typeof(Problem))]
    public class Problem4 : Problem {
        public override string Run() {
            return LargestPalinedromeFromTwoNumbers(3).ToString();
        }

        public int LargestPalinedromeFromTwoNumbers(int digits) {
            return Enumerable.Range(1, (int)Math.Pow(10, digits)).ToList().SelectMany(x => {
                return Enumerable.Range(1, x).Select(y => x*y).Where(IsPalindrome);
            }).OrderByDescending(x => x).First();
        }

        private bool IsPalindrome(int arg) {
            var charArray = arg.ToString().ToCharArray();
            Array.Reverse(charArray);
            return arg.ToString() == new String(charArray);
        }
    }
}
