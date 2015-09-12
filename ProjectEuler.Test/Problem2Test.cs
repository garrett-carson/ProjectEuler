using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem2Test {
        [TestMethod]
        public void Problem2Example() {
            // Arrange
            var problem = new Problem2();

            // Act
            var result = problem.SumEvenFibonacciRange(89);

            // Assert
            Assert.AreEqual(44, result);
        }

        [TestMethod]
        public void Problem2Answer() {
            // Arrange
            var problem = new Problem2();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("4613732", result);
        }
    }
}
