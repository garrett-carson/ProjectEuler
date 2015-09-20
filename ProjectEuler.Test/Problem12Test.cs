using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem12Test {
        [TestMethod]
        public void Problem12Example() {
            // Arrange
            var problem = new Problem12();

            // Act
            var result = problem.TriangleNumberWithMoreThanXNumberOfDivisors(5);

            // Assert
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void Problem12Answer() {
            // Arrange
            var problem = new Problem12();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("76576500", result);
        }
    }
}
