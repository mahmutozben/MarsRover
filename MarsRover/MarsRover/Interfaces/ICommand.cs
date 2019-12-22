using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Interfaces
{
    public interface ICommand
    {
        void TurnLeft();
        void TurnRight();
        void Move();
    }
}
