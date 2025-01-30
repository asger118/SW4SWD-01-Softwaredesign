
namespace Game.Models
{
    public class RedCard : ICard
    {
        private uint _value;
        private uint _multiplier = 1;

        public RedCard(uint value)
        {
            _value = value;
        }

        public uint value
        {
            get { return _value; }
        }
        public uint multiplier
        {
            get { return _multiplier; }
        }
        public string cardInfo
        {
            // Return string with card info
            get { return $"\u001b[31m{GetType().Name} {_value}\u001b[0m"; }
        }
    }
}
