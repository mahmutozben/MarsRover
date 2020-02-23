using NUnit.Framework;

namespace MarsRover.Test
{
    public class Tests
    {
        [Test]
        public void CheckPosition_IsRoverInPlateu_Success()
        {
            var rover = new Rover(new Plateau(5, 5, 0, 0));

            var result = rover.CheckPosition(new Position(4, 4, Directions.East));

            Assert.AreEqual(RoverStatus.InPlateu, result);
        }

        [Test]
        public void Check_IsThereAnyDeathHere_Succsess()
        {
            var rover = new Rover(new Plateau(2, 2, 0, 0));
            rover.AddPlaceofDeath(new Position(1, -1, Directions.South));

            var result = rover.IsThereAnyDeathHere(new Position(1, 0, Directions.East));

            Assert.IsFalse(result);
        }

        [Test]
        public void does_rover_die_when_he_walks()
        {
            var rover = new Rover(new Plateau(5, 4, 0, 0));

            var commands = "MMRMMRMRRMM";

            var armstrong = rover.Start(new Position(3, 2, Directions.East), commands);

            Assert.AreEqual(RoverStatus.Dead, rover.CheckPosition(armstrong));
        }
    }
}