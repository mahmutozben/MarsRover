namespace MarsRover
{
    public class Plateau
    {
        public int Max_X_Coordinate { get; }
        public int Max_Y_Coordinate { get; }
        public int Min_X_Coordinate { get; }
        public int Min_Y_Coordinate { get; }
        public Plateau(int max_X_Coordinate, int max_Y_Coordinate, int min_X_Coordinate, int min_Y_Coordinate)
        {
            if (max_X_Coordinate <= min_X_Coordinate)
            {
                throw new System.Exception($"Max X coordinate must be greater than min X coordinate!");
            }
            if (max_Y_Coordinate <= min_Y_Coordinate)
            {
                throw new System.Exception($"Max Y coordinate must be greater than min Y coordinate!");
            }

            this.Max_X_Coordinate = max_X_Coordinate;
            this.Max_Y_Coordinate = max_Y_Coordinate;
            this.Min_X_Coordinate = min_X_Coordinate;
            this.Min_Y_Coordinate = min_Y_Coordinate;
        }
    }
}
