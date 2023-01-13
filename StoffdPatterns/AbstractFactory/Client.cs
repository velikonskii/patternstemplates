using StoffdPatterns.AbstractFactory.Interfaces;

namespace StoffdPatterns.AbstractFactory {
    public class Client {

        public (IAbstractProductA, IAbstractProductB) Create(IAbstractFactory factory) {
            return (
                factory.CreateProductA(),
                factory.CreateProductB()
            );
        }
    }
}