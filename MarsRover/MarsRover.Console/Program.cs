using MarsRover.Interfaces;
using System;

namespace MarsRover.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Test Input:");
            System.Console.WriteLine("5 5");
            System.Console.WriteLine("1 2 N");
            System.Console.WriteLine("LMLMLMLMM");
            System.Console.WriteLine("3 3 E");
            System.Console.WriteLine("MMRMMRMRRM");
            System.Console.WriteLine();

            var rover = new Rover(new Plateau(5, 5, 0, 0));

            //First rover 
            System.Console.WriteLine("First rover .......");
            var firstRover = rover.Start(new Position(1, 2, Directions.North), "LMLMLMLMM");

            System.Console.WriteLine();

            //Second rover 
            System.Console.WriteLine("Second rover .......");
            var secondRover = rover.Start(new Position(3, 3, Directions.East), "MMRMMRMRRMM");

            System.Console.WriteLine();

            //Third rover 
            System.Console.WriteLine("Third rover .......");
            var thirdRover = rover.Start(new Position(4, 0, Directions.South), "LMLMRMM");

            System.Console.WriteLine("Expected Output:");
            System.Console.WriteLine();
            System.Console.WriteLine(rover.LocationInfo(firstRover));
            System.Console.WriteLine(rover.LocationInfo(secondRover));
            System.Console.WriteLine(rover.LocationInfo(thirdRover));

            System.Console.ReadLine();
        }
    }
}