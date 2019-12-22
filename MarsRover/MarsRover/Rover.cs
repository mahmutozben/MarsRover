using MarsRover.Constants;
using MarsRover.Interfaces;
using System;
using System.Linq;

namespace MarsRover
{
    public class Rover : ICommand
    {
        private int x;
        private int y;
        private DirectionParameter direction;
        public Rover(Position position, DirectionParameter _direction)
        {
            this.x = position.X;
            this.y = position.Y;
            this.direction = _direction;
        }

        public void Start(string commands)
        {
            Console.WriteLine($"Current location : {LocationInfo()}");
            foreach (var command in commands)
            {
                switch (command)
                {
                    case Commands.Left:
                        TurnLeft();
                        break;
                    case Commands.Right:
                        TurnRight();
                        break;
                    case Commands.Move:
                        Move();
                        break;
                    default:
                        throw new Exception($"command : {command} is not invalid.");
                }
                Console.WriteLine(LocationInfo());
            }
        }

        public void Move()
        {
            switch (direction)
            {
                case DirectionParameter.North:
                    y += 1;
                    break;
                case DirectionParameter.East:
                    x += 1;
                    break;
                case DirectionParameter.South:
                    y -= 1;
                    break;
                case DirectionParameter.West:
                    x -= 1;
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            direction = (DirectionParameter)((int)direction > (int)DirectionParameter.North ? (int)direction - 1 : (int)direction + 3 );
        }

        public void TurnRight()
        {
            direction = (DirectionParameter)((int)direction < (int)DirectionParameter.West ? (int)direction + 1 : (int)direction - 3);
        }

        public string LocationInfo()
        {
            return $" x : {x} y : {y} direction : {Enumeration.GetAll<Direction>().FirstOrDefault(x => x.Id == (int)direction).ToString()}";
        }
    }
}
