namespace StoffdPatterns.AbstractFactory.Interfaces {

    public interface IAbstractFactory {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}