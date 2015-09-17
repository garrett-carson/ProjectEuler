using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Lib;

namespace ProjectEuler.Test {
    [TestClass]
    public class Problem8Test {
        private Problem8 _problem;

        [TestInitialize]
        public void Compose() {
            var catalog = new AssemblyCatalog(Assembly.GetAssembly(typeof(Problem8)));
            var container = new CompositionContainer(catalog);
            _problem = container.GetExportedValue<Problem8>();
        }

        [TestMethod]
        public void Problem8Example() {
            // Act
            var result = _problem.LargestProductInRangeOf(4);

            // Assert
            Assert.AreEqual(5832UL, result);
        }

        [TestMethod]
        public void Problem8Answer() {
            // Act
            var result = _problem.Answer;

            // Assert
            Assert.AreEqual("23514624000", result);
        }
    }
}
