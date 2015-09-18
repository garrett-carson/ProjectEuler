using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem8Test {

        [TestMethod]
        public void Problem8Example() {
            // Arrange
            var problem = new Problem8(new Problem8Input());

            // Act
            var result = problem.LargestProductInRangeOf(4);

            // Assert
            Assert.AreEqual(5832UL, result);
        }

        [TestMethod]
        public void Problem8Answer() {
            // Arrange
            var problem = new Problem8(new Problem8Input());

            // Act
            var result = problem.Answer;

            // Assert
            Assert.AreEqual("23514624000", result);
        }
    }
}
