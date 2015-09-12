using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
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
}
