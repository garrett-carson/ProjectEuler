using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem9Test {
        [TestMethod]
        public void Problem9Answer() {
            // Arrange
            var problem = new Problem9();

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("31875000", result);
        }
    }
}
