
namespace Game.Models
{
    public class GreenCard : ICard
    {
        private uint _value;
        private uint _multiplier = 3;

        public GreenCard(uint value)
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
            get { return $"\u001b[32m{GetType().Name} {_value}\u001b[0m"; }
        }
    }
}
