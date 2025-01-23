
namespace Vehicles
{
    public class DieselEngine : IEngine
    {
        private uint _curThrottle = 0;
        private uint _maxThrottle = 0;

        public DieselEngine(uint maxThrottle)
        { 
            _maxThrottle = maxThrottle; 
        }
        public uint MaxThrottle
        {
            get { return _maxThrottle; }
        }
        public uint GetThrottle()
        {
            return _curThrottle;
        }
        public void SetThrottle(uint thr)
        {
            // Limit throttle to the maximum set in constructor
            if (_maxThrottle >= thr)
            {
                _curThrottle = thr;
            }
            else
            {
                // set to maximum allowed throttle speed
                _curThrottle = _maxThrottle;
            }
        }
    }
}
