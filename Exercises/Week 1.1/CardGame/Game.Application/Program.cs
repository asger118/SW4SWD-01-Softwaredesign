
using Game.Models;

class Program
{
    public static void Main()
    {
        do
        {
            uint gamemode = 0;
            Console.WriteLine("Enter the gamemode (0 for highest score win, 1 for lowest score win):");

            string? input = Console.ReadLine();

            if (uint.TryParse(input, out gamemode))
            {
                Console.WriteLine($"Gamemode {gamemode} selected.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid gamemode (0 or 1). Gamemode set to 0.");
            }

            GameManager gm = new GameManager();

            Player Geil = new Player("Geil");
            Player Tulle = new Player("Tulle");
            Player Asger = new Player("Asger");
            WeakPlayer Celine = new WeakPlayer("Celine");

            gm.AddPlayer(Geil);
            gm.AddPlayer(Tulle);
            gm.AddPlayer(Asger);
            gm.AddPlayer(Celine);

            gm.GameInfo();

            gm.DealCards();
            gm.DealCards();
            gm.DealCards();
            gm.DealCards();
            gm.DealCards();

            Geil.ShowHand();
            Tulle.ShowHand();
            Asger.ShowHand();
            Celine.ShowHand();

            gm.FindWinner(gamemode);

        } while (true);
    }
}