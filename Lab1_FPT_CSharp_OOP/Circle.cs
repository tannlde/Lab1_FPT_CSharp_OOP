using System;

namespace Exercise_1
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(int x, int y) : base(x, y)
        {
        }

        public Circle(int x, int y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override void Show()
        {
            Console.WriteLine($"Now at ({base.x},{base.x})");
        }

        public override string ToString() => $"A Circle with radius = {Radius} and at ({base.x},{base.x})";
    }
}
