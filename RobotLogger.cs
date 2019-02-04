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
<<<<<<< HEAD
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
=======
        public void Beep(int noOfBeeps, int volume)
        {
            _commands.Add (new Beep(noOfBeeps, volume));
            _robot.Beep(noOfBeeps, volume);
        }

        public void MoveForward(int steps)
        {
            _commands.Add(new MoveForward(steps));
            _robot.MoveForward(steps);
        }

        public void Rotate(float angle)
>>>>>>> b929c9e558fee1a1fb0f18e21a8e67311cf18649
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

