namespace iRobot
{
    public interface ICommand 
    {
        void Execute(IRobot robot);        
    }

    public class MoveForward : ICommand
    {
        private int _steps;
        public MoveForward(int steps) {
            _steps = steps;
        }
        public void Execute(IRobot robot)
        {
            robot.MoveForward(_steps);
        }
    }

    public class Beep : ICommand
    {
        private int _noOfBeeps;
        private int _volume;
        public Beep(int noOfBeeps, int volume) {
            _noOfBeeps = noOfBeeps;
            _volume = volume;
        }
        public void Execute(IRobot robot)
        {
            robot.Beep(_noOfBeeps, _volume);
        }
    }

    public class Rotate : ICommand
    {
        private float _angle;
        public Rotate(float angle) {
            _angle = angle;
        }
        public void Execute(IRobot robot)
        {
            robot.Rotate(_angle);
        }
    }
}