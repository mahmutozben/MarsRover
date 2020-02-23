namespace MarsRover
{
    public class Position
    {
        public Position(int x, int y, Directions direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }
        public Directions Direction { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public void Set_X_Coordinate(int value)
        {
            this.X += value;
        }

        public void Set_Y_Coordinate(int value)
        {
            this.Y += value;
        }

        public void SetDirection(Directions direction)
        {
            this.Direction = direction;
        }
    }
}
