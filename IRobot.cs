namespace iRobot
{
    public interface IRobot 
    {
        void MoveForward(int steps);
        void Rotate(float angle);
        void Beep(int noOfBeeps, int volume);
    }
}