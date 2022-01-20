using Exercise_1;

namespace Lab1_FPT_CSharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape line = new Line(1, 1, 10);
            line.Show();
            System.Console.WriteLine(line);
            line.MoveEast();
            line.MoveNortheast();
            line.Show();
            System.Console.WriteLine(line);

            Shape circle = new Circle(0, 0, 2);
            circle.Show();
            System.Console.WriteLine(circle);
            circle.MoveSouthwest();
            circle.MoveNorthwest();
            circle.Show();
            System.Console.WriteLine(circle);
        }
    }
}
