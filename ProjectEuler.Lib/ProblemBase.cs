using System.Text.RegularExpressions;

namespace ProjectEuler.Lib {
    public class ProblemBase {
        public string Name => Regex.Replace(this.GetType().Name, @"Problem(\d+)", @"Problem $1");

        public virtual string Answer { get; }
    }
}