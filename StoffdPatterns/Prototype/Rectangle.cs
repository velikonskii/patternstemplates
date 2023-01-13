namespace StoffdPatterns.Prototype {
    public class Rectangle : Shape {

        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }

        public Rectangle(Rectangle source) : base(source) {
            Width = source.Width;
            Height = source.Height;
        }

        public override Shape Clone() {
            return new Rectangle(this);
        }
    }
}