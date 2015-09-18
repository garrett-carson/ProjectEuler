using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem11Test {
        [TestMethod]
        public void Problem11Answer() {
            // Arrange
            var problem = new Problem11(new Problem11Input());

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("70600674", result);
        }
    }
}
