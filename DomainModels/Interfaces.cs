using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public interface IUser
    {
        int PopulationCapacityCalculator(int userLevel, int townHallLevel,int vipLevel);
    }

    public interface IUnit
    {
        double UnitPowerCalculator(UnitType unitType, int userlevel, int unitLevel, int basePower);
    }

    public interface IArmy
    {
        double armyPowerCalculator(ICollection<Minion> units, ICollection<Minion> heroes);
    }


    #region Building Interfaces
    public interface IBuilding
    {
        double UnitCooldownCalculator(BuildingTypesEnum buildingType, int buildingLevel, int userLevel);
    }

    public interface ISpawner
    {
        // For each unit available in building (each building may have more than one type of units to spawn)
        float spawnTimeCalculator(MinionsEnum unit); // other type than float for Time?
        float cooldownTimeCalculator(MinionsEnum unit);
        int spawnLimit(MinionsEnum unit); // different according to unit
    }

    public interface IVendor
    {
        Random rnd(); // randomness for the available for sale items
        ICollection<ItemsEnum> ItemGenerator(float usersLuck);  // player's luck increases the small chances of the good stuff
    }

    public interface IPvP { }
    public interface IPvE { }
    public interface ITrainingBootcamps { }
    #endregion

}
