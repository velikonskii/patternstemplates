using StoffdPatterns.AbstractFactory.Interfaces;

namespace StoffdPatterns.AbstractFactory {
    public class ConcreteFactory2 : IAbstractFactory {
        public IAbstractProductA CreateProductA() {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB() {
            return new ConcreteProductB2();
        }

    }
}