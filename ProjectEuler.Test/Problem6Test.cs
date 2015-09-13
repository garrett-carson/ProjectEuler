using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem6Test {
        [TestMethod]
        public void Problem6Example() {
            // Arrange
            var problem = new Problem6();

            // Act
            var result = problem.DiffBetweenSumOfSquaresAndSquareOfSums(10);

            // Assert
            Assert.AreEqual(2640, result);
        }

        [TestMethod]
        public void Problem6Answer() {
            // Arrange
            var problem = new Problem6();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("25164150", result);
        }
    }
}
