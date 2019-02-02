using System;

namespace iRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to IRobot!");

            var irobot1 = new RobotLogger(new Robot("Robbie"));
            irobot1.Beep(1, 10);
            irobot1.MoveForward(2);
            irobot1.Rotate(90);
            irobot1.MoveForward(1);
            irobot1.Beep(3, 15);

            Console.WriteLine("");
            Console.WriteLine("Add another robot and replay commands");
            IRobot irobot2 = new Robot("Rebecca");
            irobot1.ReplayCommands(irobot2);
        }
    }
}
