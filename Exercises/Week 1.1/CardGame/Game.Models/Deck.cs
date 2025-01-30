namespace Game.Models
{
    public class Deck
    {
        private List<ICard> _deck;
        public Deck() 
        {
            _deck = new List<ICard>();

            // Fill up deck with one of each card
            for (uint i = 1; i <= 8; i++)
            {
                _deck.Add(new GreenCard(i));
                _deck.Add(new RedCard(i));
                _deck.Add(new BlueCard(i));
                _deck.Add(new YellowCard(i));
                _deck.Add(new GoldCard(i));
            }
        }

        public int CardsLeft()
        {
            return _deck.Count;
        }

        public ICard DrawCard() 
        {
            // Draw random card from deck
            Random r = new Random();
            // Draw card
            int rInt = r.Next(0, _deck.Count);
            // Save the drawed card
            ICard drawedCard = _deck[rInt];
            // Remove card from deck
            _deck.RemoveAt(rInt);
            // return card
            return drawedCard;
        }
    }
}
