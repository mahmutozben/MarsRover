using MarsRover.Constants;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Input:");
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");
            Console.WriteLine();
            //First rover 
            Console.WriteLine("first rover .......");
            Rover firstRover = new Rover(new Position(1, 2), DirectionParameter.North);
            firstRover.Start("LMLMLMLMM");

            Console.WriteLine();

            //Second rover 
            Console.WriteLine("second rover .......");

            Rover secondRover = new Rover(new Position(3, 3), DirectionParameter.East);
            secondRover.Start("MMRMMRMRRM");

            Console.WriteLine("__Expected Output:__");
            Console.WriteLine();
            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());

            Console.ReadLine();

        }
    }
}