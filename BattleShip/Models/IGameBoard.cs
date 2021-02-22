namespace BattleShip.Models
{
    public interface IGameBoard
    {
        ushort Height { get; set; }
        string Width { get; set; }
        public bool IsShipInRange(string shipSlots);
    }
}