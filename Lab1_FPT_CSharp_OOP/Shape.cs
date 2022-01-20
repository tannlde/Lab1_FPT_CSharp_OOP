
namespace Exercise_1
{
    abstract class Shape
    {
        protected int x;
        protected int y;

        protected Shape()
        {
        }

        protected Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveEast()
        {
            x++;
        }

        public void MoveWest()
        {
            x--;
        }

        public void MoveSouth()
        {
            y--;
        }

        public void MoveNorth()
        {
            y++;
        }

        public void MoveNortheast()
        {
            MoveNorth();
            MoveEast();
        }

        public void MoveSoutheast()
        {
            MoveEast();
            MoveSouth();
        }

        public void MoveSouthwest()
        {
            MoveSouth();
            MoveWest();
        }

        public void MoveNorthwest()
        {
            MoveWest();
            MoveNorth();
        }

        public abstract void Show();

    }
}
