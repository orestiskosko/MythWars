using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public abstract class Building : IBuilding
    {
        int Id { get; set; }
        string Name { get; set; }  // ex. Barracks
        int LevelUnlocked { get; set; }  // not all buildings are available from Level_1
        BuildingTypesEnum Type { get; set; }

        double IBuilding.UnitCooldownCalculator(BuildingTypesEnum buildingType, int buildingLevel, int userLevel) { throw new NotImplementedException(); }
    }

    public class Spawner : Building, ISpawner
    {
        ICollection<MinionsEnum> units { get; set; }

        public float cooldownTimeCalculator(MinionsEnum unit) { throw new NotImplementedException(); }

        public int spawnLimit(MinionsEnum unit) { throw new NotImplementedException(); }

        public float spawnTimeCalculator(MinionsEnum unit) { throw new NotImplementedException(); }
    }

    public class Vendor : Building, IVendor
    {
        ICollection<ItemsEnum> items { get; }  // private set
        int numberOfItemsForSale { get; set; }  // not all vendors have the same number of items for sale
        float cooldownTimeToChangeItems { get; set; }
        bool everythingWasSold { get; set; }  // idea, if everything is bought by the player, he gets an extra something

        // defining the items offered
        public ICollection<ItemsEnum> ItemGenerator(float usersLuck) { throw new NotImplementedException(); }

        public Random rnd() { throw new NotImplementedException(); }
    }

    public class PvP : Building, IPvP
    {
        // needs brainstorming
    }

    public class PvE : Building, IPvE
    {
        // needs brainstorming
    }

    public class TrainingBootcamps : Building, ITrainingBootcamps
    {
        // needs brainstorming
    }
}


