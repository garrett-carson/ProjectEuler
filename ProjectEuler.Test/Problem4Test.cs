using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem4Test {
        [TestMethod]
        public void Problem4Example() {
            // Arrange
            var problem = new Problem4();

            // Act
            var result = problem.LargestPalinedromeFromTwoNumbers(2);

            // Assert
            Assert.AreEqual(9009, result);
        }

        [TestMethod]
        public void Problem4Answer() {
            // Arrange
            var problem = new Problem4();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("906609", result);
        }
    }
}
