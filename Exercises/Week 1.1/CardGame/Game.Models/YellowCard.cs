
namespace Game.Models
{
    public class YellowCard : ICard
    {
        private uint _value;
        private uint _multiplier = 4;

        public YellowCard(uint value)
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
            get { return $"\u001b[33m{GetType().Name} {_value}\u001b[0m"; }
        }
    }
}
