using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem5Test {
        [TestMethod]
        public void Problem5Example() {
            // Arrange
            var problem = new Problem5();

            // Act
            var result = problem.LeastCommonMultipleFromRange(10);

            // Assert
            Assert.AreEqual(2520, result);
        }

        [TestMethod]
        public void Problem5Answer() {
            // Arrange
            var problem = new Problem5();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("232792560", result);
        }
    }
}
