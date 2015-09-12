using System.Text.RegularExpressions;

namespace ProjectEuler.Lib {
    public abstract class Problem {
        public string Name => Regex.Replace(this.GetType().Name, @"Problem(\d+)", @"Problem $1");

        private string _answer;
        public string Answer => _answer ?? (_answer = Run());

        public abstract string Run();
    }
}