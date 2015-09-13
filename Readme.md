# ProjectEuler

This is my project for tackling project euler questions. It is intended for personal use but contributions, suggestions or criticisms are welcome.

Please see [Project Euler](https://projecteuler.net/) for more information.

## ProjectEuler.Console

Runs all the tests in order and displays the output. Uses MEF to load up all the problems entered in ProjectEuler.Lib without having to specifically type them into a list anywhere.

## ProjectEuler.Lib

Contains solutions for problems. The `abstract class` in Problem.cs defines the structure for providing answers and includes some common functionality like `Name`.
Individual solutions override `Run()` which is lazy loaded and memorized by `Answer`. `Run()` generally calls a helper function with an argument. The helper function allows unit testing against against multiple scenarios when multiple examples are given while still allowing `Answer` to be the answer to the full question.

## ProjectEuler.Test

Runs automated unit tests against problems. This is used for test driven development, but also shows off how solutions match both example cases and typically larger final problem cases.

## Usage

To see my particular solution to a problem, e.g. problem 1, visit ProjectEuler.Lib\Problem1.cs

	// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // 
    // Find the sum of all the multiples of 3 or 5 below 1000.
	public class Problem1 : Problem {
        public override string Run() {
            return SumRangeDivisibleByThreeOrFive(1000).ToString();
        }

        public int SumRangeDivisibleByThreeOrFive(int max) {
            return Enumerable.Range(0, max)
	            .Where(x => x % 3 == 0 || x % 5 == 0)
	            .Sum();
        }
    }

Also visit ProjectEuler.Test\Problem1Test.cs for automated tests.

	[TestClass]
    public class Problem1Test {
        [TestMethod]
        public void Problem1Example() {
            // Arrange
            var problem = new Problem1();

            // Act
            var result = problem.SumRangeDivisibleByThreeOrFive(10);

            // Assert
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Problem1Answer() {
            // Arrange
            var problem = new Problem1();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("233168", result);
        }
    }
