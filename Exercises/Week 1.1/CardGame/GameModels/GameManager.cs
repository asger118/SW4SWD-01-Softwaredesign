namespace Game.Models
{
    public class GameManager
    {
        private Deck _deck;
        private List<Player> _players;

        public GameManager()
        {
            _deck = new Deck();
            _players = new List<Player>();
        }

        public void AddPlayer(Player p)
        {
            _players.Add(p);
        }

        public void FindWinner(uint gamemode)
        {
            // Print out chosen gamemode
            if (gamemode == 0)
            {
                Console.WriteLine("\nGamemode 0 player with highest  score wins");
            }
            else if (gamemode == 1)
            {
                Console.WriteLine("\nGamemode 1 player with lowest score wins");
            }

            Player player = _players[0];

            if (player != null)
            {
                foreach (var p in _players)
                {
                    Console.WriteLine($"    {p.name}'s score: {p.GetHandValue()}");
                    if (gamemode == 0)
                    {
                        // find player with highest score
                        if (player.GetHandValue() < p.GetHandValue())
                            player = p;
                    }
                    else if (gamemode == 1)
                    {
                        // find player with lowest score
                        if (player.GetHandValue() > p.GetHandValue())
                            player = p;
                    }
                }
                Console.WriteLine($"\nThe winner is {player.name} with {player.GetHandValue()} points!");
            }
            else
            {
                Console.WriteLine("No players in the game");
            }

        }

        public void DealCards()
        {
            if (_deck.CardsLeft() > _players.Count)
            {
                foreach (var player in _players)
                {
                    player.AddCardToHand(_deck.DrawCard());
                }
            }
        }

        public void GameInfo()
        {
            Console.WriteLine("Welcome to the Card Game!");
            Console.WriteLine();
            Console.WriteLine("Game Overview:");
            Console.WriteLine(" - This game includes 5 types of cards, with 8 cards each ranging from 1 to 8.");
            Console.WriteLine(" - Each card has a multiplier, and your score are calculated as:");
            Console.WriteLine("     Card Number × Multiplier");
            Console.WriteLine();
            Console.WriteLine("Game Modes:");
            Console.WriteLine(" - Gamemode 0: Highest score win.");
            Console.WriteLine(" - Gamemode 1: Lowest score win.");
            Console.WriteLine();
            Console.WriteLine("Card Types and Multipliers:");
            Console.WriteLine($"    \u001b[31mRed Card     × 1\u001b[0m");
            Console.WriteLine($"    \u001b[34mBlue Card    × 2\u001b[0m");
            Console.WriteLine($"    \u001b[32mGreen Card   × 3\u001b[0m");
            Console.WriteLine($"    \u001b[33mYellow Card  × 4\u001b[0m");
            Console.WriteLine($"    \u001b[38;2;255;215;0mGold Card    × 5\u001b[0m");
            Console.WriteLine();
        }

    }
}
