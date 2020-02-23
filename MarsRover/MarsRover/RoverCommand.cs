using MarsRover.Interfaces;

namespace MarsRover
{
    public class RoverCommand : ICommand
    {
        public Position Move(Position position)
        {
            switch (position.Direction)
            {
                case Directions.North:
                    position.AddValueTo_Y_Coordinate(1);
                    break;
                case Directions.East:
                    position.AddValueTo_X_Coordinate(1);
                    break;
                case Directions.South:
                    position.AddValueTo_Y_Coordinate(-1);
                    break;
                case Directions.West:
                    position.AddValueTo_X_Coordinate(-1);
                    break;
                default:
                    break;
            }

            return position;
        }

        public Direction TurnLeft(Directions direction)
        {
            direction = (Directions)((int)direction > (int)Directions.North ? (int)direction - 1 : (int)direction + 3);

            return Direction.GetDirection(direction);
        }

        public Direction TurnRight(Directions direction)
        {
            direction = (Directions)((int)direction < (int)Directions.West ? (int)direction + 1 : (int)direction - 3);

            return Direction.GetDirection(direction);
        }
    }
}
