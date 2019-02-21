using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Army
    {
        ICollection<Unit> Units { get; set; }
    }

    //// dummy
    //public class PlayerUnits
    //{
        
    //}

    //// dummy
    //public class PlayerArmy
    //{

    //}

    //// dummy
    //public class PlayerHeroes
    //{

    //}

    //public interface IHero : IUnit
    //{
    //    Rarity rarity { get; set; }

    //    ICollection<HeroStats> stats { get; set; }
    //    ICollection<HeroSkills> skills { get; set; }
    //}

    //public interface IArmy
    //{
    //    int ID { get; set; }
    //    double moraleMultiplier { get; set; }
    //    ICollection<PlayerUnits> units { get; set; }
    //    ICollection<PlayerHeroes> heroes { get; set; }

    //    double armyPowerCalculator(ICollection<PlayerUnits> units, ICollection<PlayerHeroes> heroes);
    //}

    //#region Buildings
    //public interface IBuildings
    //{
    //    int ID { get; set; }
    //    string name { get; set; }  // ex. Barracks
    //    int levelUnlocked { get; set; }  // not all buildings are available from Level_1
    //    BuildingTypes type { get; set; }
    //}
    
    //public interface ISpawners: IBuildings
    //{
    //    ICollection<Units> units { get; set; }

    //    // For each unit available in building (each building may have more than one type of units to spawn)
    //    float spawnTimeCalculator(Units unit); // other type than float for Time?
    //    float cooldownTimeCalculator(Units unit);
    //    int spawnLimit(Units unit); // different according to unit
    //}

    //public interface IVendors: IBuildings
    //{
    //    Random rnd(); // randomness for the available for sale items
    //    ICollection<Items> items { get; }  // private set
    //    int numberOfItemsForSale { get; set; }  // not all vendors have the same number of items for sale
    //    float cooldownTimeToChangeItems { get; set; }
    //    bool everythingWasSold { get; set; }  // idea, if everything is bought by the player, he gets an extra something

    //    // defining the items offered
    //    ICollection<Items> ItemGenerator(float PlayersLuck);  // player's luck increases the small chances of the good stuff
    //}

    //public interface IPVP : IBuildings
    //{
    //    // needs brainstorming
    //}

    //public interface IPVE : IBuildings
    //{
    //    // needs brainstorming
    //}

    //public interface ITrainingBootcamps : IBuildings
    //{
    //    // needs brainstorming
    //}
    //#endregion

    //public interface IItems
    //{
    //    int ID { get; set; }
    //    Currencies currency { get; set; }
    //    int vendorCost { get; set; }  // according to self currency, it is going to be pre-fixed
    //    int sellProfit { get; set; }  // same here, pre-fixed
    //    Rarity rarity { get; set; }

    //    // make room for enchantment
    //    // make room for crafting
    //    // note that not all items are sold in vendor shops, some are crafted, other are dropped
    //}
}
