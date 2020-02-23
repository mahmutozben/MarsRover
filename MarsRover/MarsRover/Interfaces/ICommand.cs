
namespace MarsRover.Interfaces
{
    public interface ICommand
    {
        Direction TurnLeft(Directions direction);
        Direction TurnRight(Directions direction);
        Position Move(Position position);
    }
}
