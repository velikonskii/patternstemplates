using System;
using System.Collections.Generic;
using System.Linq;
using StoffdPatterns.AbstractFactory;
using StoffdPatterns.Builder;
using StoffdPatterns.Command;
using StoffdPatterns.Prototype;
using StoffdPatterns.Strategy;

namespace StoffdPatterns {
    class Program {
        static void Main(string[] args) {

            new CommandClient().Start();
            return;
            //----------------------------------------------------
            //Builder---------------------------------------------
            //Имеется объект со множеством свойств
            //Каждое свойство требует инициализации
            //При этом существуют понятные паттерны инициализации (билдер с директором)
            //OR существует несколько способов построения некоторого элемента объекта(Типы билдера)

            //Note: если набор паттернов статичен, то поля билдера(SetGarden и тд) можно сделать без параметров
            // В этом случае директор будет выступать фасадом



            HouseBuilderTypeA builderTypeA= new HouseBuilderTypeA();
            HouseBuilderTypeB builderTypeB= new HouseBuilderTypeB();
            Director director = new Director();
            director.ConstructHouseTypeA2Floors(builderTypeA);
            House house = builderTypeA.GetResult();
            house.HouseShow();
            director.ConstructHouseTypeB(builderTypeB);
            House house3 = builderTypeB.GetResult();
            house3.HouseShow();

            director.ConstructHouseTypeA6Floors(builderTypeA);
            House house2 = builderTypeA.GetResult();
            house2.HouseShow();


            //----------------------------------------------------
            //Prototype--------------------------------------------
            //Создает новый объект, копируя при этом состояние его полей
            //Если имеет место наследование, то клонирование следует переопределить в дочерних классах
            //Похоже что в recordах метод уже реализован

            var shapes = new List<Shape>();
            var circle = new Circle {
                X = 10,
                Y = 10,
                Color = 10,
                Radius = 12
            };

            var rectangle = new Rectangle {
                X = 10,
                Y = 10,
                Color = 10,
                Height = 100,
                Width = 200
            };


            shapes.Add(circle);
            shapes.Add(circle.Clone());
            shapes.Add(rectangle);
            shapes.Add(rectangle.Clone());


            //----------------------------------------------------
            //Strategy--------------------------------------------

            //Есть какая-то бизнес логика, имеющая одинаковый набор входных данных
            // Но разные поведения(алгоритмы расчета). Необходимо уметь подменять эти поведения на лету
            //Пример: 2Gis
            //Расчитать путь домой пешком, на машине или общественном транспорте

            var strategyA = new ConcreteStrategyA();
            var strategyB = new ConcreteStrategyB();

            var gadget = new Context();
            Console.WriteLine("using strategy A");
            gadget.Strategy = strategyA;
            gadget.Execute("Home", "Work");

            Console.WriteLine("Changing strategy to B");
            gadget.Strategy = strategyB;
            gadget.Execute("Home", "Work");



            //Есть несколько комплектов наборов сущностей:
            //Стул, стол, кровать - Деревянные обычные
            //Стул, стол, кровать - Офисные пластиковые
            //Стул, стол, кровать - Изысканные выебистые

            //1. Элементы должны взаимодействовать между собой внутри набора. Но не между наборами
            //2. Должен быть один общий интерфейс работы
            // Пример. Создать набор деревянной мебели(Один раз указываем какую мебель используем). Подвинуть стул к столу
            // Сесть на стул и.т.д. Т.е после создания мы не должны постоянно говорить: подвинь деревянный стул к деревянному столу
            // Более того. Философия паттерна говорит о том, что не должно быть взаимодействия между деревянным и например выебистым стулом


            var client = new Client();
            var factories = client.Create(new ConcreteFactory1());
            Console.WriteLine(factories.Item1.UsefulFunctionA());
            Console.WriteLine(factories.Item2.UsefulFunctionB());
            //Взаимодействие между элементами набора
            Console.WriteLine(factories.Item2.AnotherUsefulFunctionB(factories.Item1));

            var factories2 = client.Create(new ConcreteFactory2());
            Console.WriteLine(factories2.Item1.UsefulFunctionA());
            Console.WriteLine(factories2.Item2.UsefulFunctionB());
            Console.WriteLine(factories2.Item2.AnotherUsefulFunctionB(factories2.Item1));
            //Синтаксически так можно, но лучше так не делать, потому что нарушает логику AF:
            Console.WriteLine(factories2.Item2.AnotherUsefulFunctionB(factories.Item1));






        }
    }
}