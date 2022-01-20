using System;

namespace Exercise_1
{
    class Line : Shape
    {
        private double length;

        public Line()
        {
        }

        public Line(double length)
        {
            Length = length;
        }

        public Line(int x, int y) : base(x, y)
        {
        }

        public Line(int x, int y, double length) : base(x, y)
        {
            Length = length;
        }
        public double Length { get => length; set => length = value; }

        public override void Show()
        {
            Console.WriteLine($"Now at ({base.x},{base.x})");
        }

        public override string ToString() => $"A Line with length = {Length} and at ({base.x},{base.x})";
    }
}
