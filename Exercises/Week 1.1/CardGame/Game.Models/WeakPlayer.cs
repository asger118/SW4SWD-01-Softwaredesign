namespace Game.Models
{
    public class WeakPlayer : Player
    {
        // Maximum number of cards allowed in hand
        private uint _handLimit = 3; 

        public WeakPlayer(string name) : base(name) { }

        public override void AddCardToHand(ICard card)
        {
            // If hand is full, remove the first card and add the new one
            if (_hand.Count >= _handLimit)
            {
                // Remove the oldest card (FIFO behavior)
                _hand.RemoveAt(0); 
            }

            // Add the new card to the hand.
            _hand.Add(card);
        }
    }
}
