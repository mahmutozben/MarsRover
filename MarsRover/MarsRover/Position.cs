using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Position
    {
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
