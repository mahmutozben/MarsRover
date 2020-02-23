using MarsRover.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public enum RoverStatus
    {
        Dead = 0,
        InBorder = 1,
        InPlateu = 2
    }
    public class Rover
    {
        public List<Position> _placesOfDeath { get; }
        private Plateau Plateau;

        public Rover()
        {
            _placesOfDeath = new List<Position>();
            this.Plateau = new Plateau(5, 5, 0, 0);
        }
        public Rover(Plateau plateau)
        {
            _placesOfDeath = new List<Position>();
            this.Plateau = plateau;
        }

        public Position Start(Position position, string commands)
        {
            Console.WriteLine($"Current location : {LocationInfo(position)}");

            ICommand command = new RoverCommand();
            var direction = Direction.GetDirection(position.Direction);

            foreach (var cmd in commands)
            {
                switch (cmd)
                {
                    case Commands.Left:
                        direction = command.TurnLeft((Directions)direction.Id);
                        position.SetDirection((Directions)direction.Id);
                        break;
                    case Commands.Right:
                        direction = command.TurnRight((Directions)direction.Id);
                        position.SetDirection((Directions)direction.Id);
                        break;
                    case Commands.Move:
                        {
                            if (IsThereAnyDeathHere(position))
                            {
                                Console.WriteLine("You cannot go further. Try another direction please..");
                                var newCommand = Console.ReadLine();
                                this.Start(position, newCommand);
                            }

                            position = command.Move(position);

                            if (CheckPosition(position) == RoverStatus.Dead)
                            {
                                Console.WriteLine("Rest in peace!");
                                commands = string.Empty;
                            }
                        }
                        break;
                    default:
                        throw new Exception($"command : {command} is not invalid.");
                }
                Console.WriteLine(LocationInfo(position));
            }

            return position;
        }

        public RoverStatus CheckPosition(Position position)
        {
            var roverStatus = RoverStatus.InPlateu;

            if (position.X > Plateau.Max_X_Coordinate || position.X < Plateau.Min_X_Coordinate)
            {
                roverStatus = RoverStatus.Dead;
                AddPlaceofDeath(position);
            }
            else if (position.Y > Plateau.Max_Y_Coordinate || position.Y < Plateau.Min_Y_Coordinate)
            {
                roverStatus = RoverStatus.Dead;
                AddPlaceofDeath(position);
            }

            return roverStatus;
        }

        public bool IsThereAnyDeathHere(Position position)
        {
            bool result = false;

            if (_placesOfDeath.Any(pst => pst.X == position.X + 1 && pst.Y == position.Y && pst.Direction == position.Direction))
            {
                result = true;
            }
            else if (_placesOfDeath.Any(pst => pst.X == position.X - 1 && pst.Y == position.Y && pst.Direction == position.Direction))
            {
                result = true;
            }
            else if (_placesOfDeath.Any(pst => pst.Y == position.Y + 1 && pst.X == position.X && pst.Direction == position.Direction))
            {
                result = true;
            }
            else if (_placesOfDeath.Any(pst => pst.Y == position.Y - 1 && pst.X == position.X && pst.Direction == position.Direction))
            {
                result = true;
            }

            return result;
        }

        public void AddPlaceofDeath(Position position)
        {
            _placesOfDeath.Add(position);
        }
        public string LocationInfo(Position position)
        {
            return $" x : {position.X} y : {position.Y} direction : {Enumeration.GetAll<Direction>().FirstOrDefault(x => x.Id == (int)position.Direction).ToString()}";
        }
    }
}
