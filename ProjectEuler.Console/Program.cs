using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using ProjectEuler.Lib;

namespace ProjectEuler.Console {
    class Program {
        [ImportMany(typeof(Problem))]
        private Problem[] _problems;

        static void Main(string[] args) {
            var program = new Program();
            program.Run();
        }

        private void Run() {
            Compose();
            foreach (var problem in _problems) {
                System.Console.WriteLine("{0}: {1}", problem.Name, problem.Answer);
            }
            if (Debugger.IsAttached) {
                System.Console.Write("Press any key to continue...");
                System.Console.ReadKey();
            }
        }

        private void Compose() {
            var catalog = new DirectoryCatalog(".", "*");
            CompositionContainer container = new CompositionContainer(catalog);
            container.SatisfyImportsOnce(this);
        }
    }
}
