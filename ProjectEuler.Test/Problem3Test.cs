using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem3Test {
        [TestMethod]
        public void Problem3Example() {
            // Arrange
            var problem = new Problem3();

            // Act
            var result = problem.LargestPrimeFactor(13195);

            // Assert
            Assert.AreEqual((ulong)29, result);
        }

        [TestMethod]
        public void Problem3Answer() {
            // Arrange
            var problem = new Problem3();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("6857", result);
        }
    }
}
