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
            Console.WriteLine("First rover .......");
            Rover firstRover = new Rover(new Position(1, 2), DirectionParameter.North);
            firstRover.Start("LMLMLMLMM");

            Console.WriteLine();

            //Second rover 
            Console.WriteLine("Second rover .......");
            Rover secondRover = new Rover(new Position(3, 3), DirectionParameter.East);
            secondRover.Start("MMRMMRMRRM");

            Console.WriteLine("Expected Output:");
            Console.WriteLine();
            Console.WriteLine(firstRover.LocationInfo());
            Console.WriteLine(secondRover.LocationInfo());
            Console.WriteLine("Do you want to continue? Y/N");
            var isProcessContinue = Console.ReadLine();

            if (isProcessContinue.ToUpper().Equals("Y"))
            {
                Console.WriteLine("Enter execute command for First rover(L,M,R)..");
                var firstCommand = Console.ReadLine();
                Console.WriteLine("Enter execute command for second rover(L,M,R)..");
                var secondCommand = Console.ReadLine();
                //First rover 
                Console.WriteLine("First rover .......");
                firstRover.Start(firstCommand);
                Console.WriteLine(firstRover.LocationInfo());
                //Second rover 
                Console.WriteLine("Second rover .......");
                secondRover.Start(secondCommand);
                Console.WriteLine(secondRover.LocationInfo());
            }

            Console.ReadLine();
        }
    }
}