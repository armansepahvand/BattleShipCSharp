using System.Collections.Generic;

namespace BattleShip.Models
{
    public interface IShip
    {
        int Length { get; set; }
        string ShipString { get; set; }

        List<string> GetShipSlots();
    }
}