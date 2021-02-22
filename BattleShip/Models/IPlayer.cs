namespace BattleShip.Models
{
    public interface IPlayer
    {
        IGameBoard playerBoard { get; set; }
        IShip playerShip { get; set; }
    }
}