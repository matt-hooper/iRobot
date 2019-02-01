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

        public void Beep(int noOfBeeps, int volume)
        {
            Console.WriteLine($"Robot: {_name}. Beep at volume {volume}, {noOfBeeps} time{(noOfBeeps == 1 ? "" : "s")}.");
        }

        public void MoveForward(int steps)
        {
            Console.WriteLine($"Robot: {_name}. Move Forward {steps} step{(steps == 1 ? "" : "s")}.");
        }

        public void Rotate(float angle)
        {
            Console.WriteLine($"Robot: {_name}. Rotate {angle} degree{(angle == 1 ? "" : "s")}.");
        }
    }
}    