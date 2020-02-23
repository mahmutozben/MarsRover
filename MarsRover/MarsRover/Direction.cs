using System.Linq;

namespace MarsRover
{
    public class Direction : Enumeration
    {
        public static Direction North = new Direction((int)Directions.North,"N");
        public static Direction East = new Direction((int)Directions.East, "E");
        public static Direction South = new Direction((int)Directions.South, "S");
        public static Direction West = new Direction((int)Directions.West, "W");
        public Direction(int id, string name) : base(id, name)
        {
        }

        public static Direction GetDirection(Directions direction)
        {
            return GetAll<Direction>().First(x => x.Id.Equals((int)direction));
        }
    }
    public enum Directions
    {
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }
}
