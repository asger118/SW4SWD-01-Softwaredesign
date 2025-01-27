namespace Game.Models
{
    public class BlueCard : ICard
    {
        private uint value_;
        private uint multiplier_ = 2;
       
        public BlueCard(uint value)
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
            get { return $"\u001b[34m{GetType().Name} {value_}\u001b[0m"; }
        }
    }
}
