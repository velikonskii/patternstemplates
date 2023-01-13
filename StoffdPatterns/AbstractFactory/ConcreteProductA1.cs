using StoffdPatterns.AbstractFactory.Interfaces;

namespace StoffdPatterns.AbstractFactory {
    public class ConcreteProductA1 : IAbstractProductA {
        public string UsefulFunctionA() {
            return "result of the product A1";
        }
    }
}