
using System;
using StoffdPatterns.Strategy.Interfaces;

namespace StoffdPatterns.Strategy {
    public class ConcreteStrategyA : IStrategy {
        public void Execute(string a, string b) {
            Console.WriteLine($"strategy 1 {a}----->{b}");
        }
    }
}