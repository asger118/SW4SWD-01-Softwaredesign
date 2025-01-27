namespace Game.Models
{
    public class GoldCard : ICard
    {
        private uint value_;
        private uint multiplier_ = 5;

        public GoldCard(uint value)
        {
            value_ = value;
        }

        public uint value
        {
            get { return value_; }
        }
        public uint multiplier
        {
            get { return multiplier_; }
        }
        public string cardInfo
        {
            get { return $"\u001b[38;2;255;215;0m{GetType().Name} {value_}\u001b[0m"; }
        }
    }
}
