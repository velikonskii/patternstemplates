
using System;
using StoffdPatterns.Strategy.Interfaces;

namespace StoffdPatterns.Strategy {
    public class ConcreteStrategyB : IStrategy {
        public void Execute(string a, string b) {
            Console.WriteLine($"strategy 2 {a}<====={b}");
        }
    }
}