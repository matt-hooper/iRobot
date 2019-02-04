using System;

namespace iRobot
{
    public class Robot : IRobot
    {
        private string _name;

        public Robot(string name)
        {
            _name = name;
        }

        public void Beep(int numberOfBeeps , double volume)
        {
            Console.WriteLine($"Robot: {_name}. Beep at volume {volume}, {numberOfBeeps} time{(numberOfBeeps == 1 ? "" : "s")}.");
        }

        public void MoveForward(int numberOfSteps )
        {
            Console.WriteLine($"Robot: {_name}. Move Forward {numberOfSteps } step{(numberOfSteps  == 1 ? "" : "s")}.");
        }

        public void Rotate(double angle)
        {
            Console.WriteLine($"Robot: {_name}. Rotate {angle} degree{(angle == 1 ? "" : "s")}.");
        }
    }
}    