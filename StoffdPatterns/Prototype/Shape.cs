using System.Transactions;

namespace StoffdPatterns.Prototype {

    public abstract class Shape {
        public Shape() {}

        public Shape(Shape source) {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        public abstract Shape Clone();

        public int X { get; set; }
        public int Y { get; set; }
        public int Color { get; set; }

    }

}