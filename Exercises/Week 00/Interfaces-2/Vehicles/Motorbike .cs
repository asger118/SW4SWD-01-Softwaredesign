namespace Vehicles
{
    public class MotorBike
    {
        private IEngine _engine = null;

        public MotorBike(IEngine engine)
        {
            _engine = engine;
        }
        public void RunAtHalfSpeed()
        {
            _engine.SetThrottle(_engine.MaxThrottle / 2);
        }
    }
}
