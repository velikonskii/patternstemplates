using System;
using StoffdPatterns.Strategy.Interfaces;

namespace StoffdPatterns.Strategy {

    public class Context {
        public IStrategy Strategy { get; set; }

        public void Execute(string a, string b) {
            Strategy.Execute(a,b);
        }
    }
}