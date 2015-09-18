using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
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
            foreach (var problem in _problems.OrderByDescending(x => x.Name, new NaturalStringComparer())) {
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

        [SuppressUnmanagedCodeSecurity]
        internal static class SafeNativeMethods {
            [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
            public static extern int StrCmpLogicalW(string psz1, string psz2);
        }

        public sealed class NaturalStringComparer : IComparer<string> {
            public int Compare(string a, string b) {
                return SafeNativeMethods.StrCmpLogicalW(a, b);
            }
        }
    }
}
