namespace iRobot
{
    public interface ICommand 
    {
        void Execute(IRobot robot);        
    }

    public class MoveForward : ICommand
    {
        private int _numberOfSteps;
        public MoveForward(int numberOfSteps) {
            _numberOfSteps = numberOfSteps;
        }
        public void Execute(IRobot robot)
        {
            robot.MoveForward(_numberOfSteps);
        }
    }

    public class Beep : ICommand
    {
        private int _numberOfBeeps;
        private double _volume;
        public Beep(int numberOfBeeps, double volume) {
            _numberOfBeeps = numberOfBeeps;
            _volume = volume;
        }
        public void Execute(IRobot robot)
        {
            robot.Beep(_numberOfBeeps, _volume);
        }
    }

    public class Rotate : ICommand
    {
        private double _angle;
        public Rotate(double angle) {
            _angle = angle;
        }
        public void Execute(IRobot robot)
        {
            robot.Rotate(_angle);
        }
    }
}