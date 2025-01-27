namespace Game.Models
{
    public class Player
    {
        private string _name;
        protected List<ICard> _hand;

        public string name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Player(string name) 
        {
            _hand = new List<ICard>();
            this._name = name;
        }

        public uint GetHandValue() 
        {
            uint sum = 0;
            // Calculate sum by card value and multiplier
            foreach (ICard c in _hand) 
            {
                sum += c.value * c.multiplier;
            }
            return sum;
        }

        public virtual void ShowHand() 
        {
            // Write info of cards on hand
            Console.WriteLine($"{_name}'s hand:");
            foreach (ICard c in _hand)
            {
                
                Console.WriteLine($"    {c.cardInfo}");
            }
        }

        public virtual void AddCardToHand(ICard card)
        {
            _hand.Add(card);
        }
        
    }
}
