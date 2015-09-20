using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem13Test {
        [TestMethod]
        public void Problem13Answer() {
            // Arrange
            var problem = new Problem13(new Problem13Input());

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("5537376230", result);
        }
    }
}
