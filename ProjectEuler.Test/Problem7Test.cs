using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem7Test {
        [TestMethod]
        public void Problem7Example() {
            // Arrange
            var problem = new Problem7();

            // Act
            var result = problem.NthUlongPrime(6);

            // Assert
            Assert.AreEqual((ulong)13, result);
        }

        [TestMethod]
        public void Problem7Answer() {
            // Arrange
            var problem = new Problem7();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("104743", result);
        }
    }
}
