namespace MarsRover.Constants
{
    public class Direction : Enumeration
    {
        public static Direction North = new Direction((int)DirectionParameter.North,"N");
        public static Direction East = new Direction((int)DirectionParameter.East, "E");
        public static Direction South = new Direction((int)DirectionParameter.South, "S");
        public static Direction West = new Direction((int)DirectionParameter.West, "W");
        public Direction(int id, string name) : base(id, name)
        {
        }
    }
    public enum DirectionParameter
    {
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }
}
