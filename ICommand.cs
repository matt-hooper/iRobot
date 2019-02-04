namespace iRobot
{
    public interface ICommand 
    {
        void Execute(IRobot robot);        
    }

    public class MoveForward : ICommand
    {
<<<<<<< HEAD
        private int _numberOfSteps;
        public MoveForward(int numberOfSteps) {
            _numberOfSteps = numberOfSteps;
        }
        public void Execute(IRobot robot)
        {
            robot.MoveForward(_numberOfSteps);
=======
        private int _steps;
        public MoveForward(int steps) {
            _steps = steps;
        }
        public void Execute(IRobot robot)
        {
            robot.MoveForward(_steps);
>>>>>>> b929c9e558fee1a1fb0f18e21a8e67311cf18649
        }
    }

    public class Beep : ICommand
    {
<<<<<<< HEAD
        private int _numberOfBeeps;
        private double _volume;
        public Beep(int numberOfBeeps, double volume) {
            _numberOfBeeps = numberOfBeeps;
=======
        private int _noOfBeeps;
        private int _volume;
        public Beep(int noOfBeeps, int volume) {
            _noOfBeeps = noOfBeeps;
>>>>>>> b929c9e558fee1a1fb0f18e21a8e67311cf18649
            _volume = volume;
        }
        public void Execute(IRobot robot)
        {
<<<<<<< HEAD
            robot.Beep(_numberOfBeeps, _volume);
=======
            robot.Beep(_noOfBeeps, _volume);
>>>>>>> b929c9e558fee1a1fb0f18e21a8e67311cf18649
        }
    }

    public class Rotate : ICommand
    {
<<<<<<< HEAD
        private double _angle;
        public Rotate(double angle) {
=======
        private float _angle;
        public Rotate(float angle) {
>>>>>>> b929c9e558fee1a1fb0f18e21a8e67311cf18649
            _angle = angle;
        }
        public void Execute(IRobot robot)
        {
            robot.Rotate(_angle);
        }
    }
}