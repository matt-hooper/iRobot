using System;
using System.Collections.Generic;

namespace iRobot
{
    public class RobotLogger : IRobot
    {
        private IRobot _robot;
        private List<ICommand> _commands;

        public RobotLogger(IRobot robot)
        {
            _robot = robot;
            _commands = new List<ICommand>();
        }
        public void Beep(int numberOfBeeps, double volume)
        {
            _commands.Add (new Beep(numberOfBeeps, volume));
            _robot.Beep(numberOfBeeps, volume);
        }

        public void MoveForward(int numberOfSteps)
        {
            _commands.Add(new MoveForward(numberOfSteps));
            _robot.MoveForward(numberOfSteps);
        }

        public void Rotate(double angle)
        {
            _commands.Add(new Rotate(angle));
            _robot.Rotate(angle);
        }

        public void ReplayCommands(IRobot robot)
        {
            foreach (var command in _commands)
            {
                command.Execute(robot);
            }
        }
    }
}

