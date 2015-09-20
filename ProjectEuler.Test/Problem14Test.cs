using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem14Test {
        [TestMethod]
        public void Problem14Example() {
            // Arrange
            var problem = new Problem14();

            // Act
            var result = problem.CollatzSequence(13).ToArray();

            // Assert
            CollectionAssert.AreEqual(new ulong[] { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 }, result);
        }

        [TestMethod]
        public void Problem14Answer() {
            // Arrange
            var problem = new Problem14();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("837799", result);
        }
    }
}
