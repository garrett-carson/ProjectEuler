using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using ProjectEuler.Lib;

namespace ProjectEuler.Console {
    class Program {
        [ImportMany(typeof(ProblemBase))]
        private ProblemBase[] _problems;

        static void Main(string[] args) {
            var program = new Program();
            program.Run();
            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }

        private void Run() {
            Compose();
            foreach (var problem in _problems) {
                System.Console.WriteLine("{0}: {1}", problem.Name, problem.Answer);
            }
        }

        private void Compose() {
            var catalog = new DirectoryCatalog(".", "*");
            CompositionContainer container = new CompositionContainer(catalog);
            container.SatisfyImportsOnce(this);
        }
    }
}
