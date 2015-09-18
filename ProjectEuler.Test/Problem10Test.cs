using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem10Test {
        [TestMethod]
        public void Problem10Example() {
            // Arrange
            var problem = new Problem10();

            // Act
            var result = problem.SumOfPrimesBelow(10);

            // Assert
            Assert.AreEqual((ulong)17, result);
        }

        [TestMethod]
        public void Problem10Answer() {
            // Arrange
            var problem = new Problem10();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("142913828922", result);
        }
    }
}
