
namespace Game.Models 
{
    public interface ICard 
    {
        uint value { get; }
        uint multiplier { get; }
        string cardInfo { get; }
    }
}
