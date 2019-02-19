using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public enum Mythology { Greek, Egyptian, Norse}
    public enum Units { Minotaur, Cyclops, Centaur, Phoenix, Sphinx, Mummy, Giant, Valkyrie, Viking}  // some dummy units ideas  {maybe separate later according to Mythology origin}
    public enum Heroes { Achilles, Hercules, Ra, Anubis, Thor, Odin}  // same as above
    public enum HeroSkills { Stun, Bash, Kek, Lol}  // dummies
    public enum HeroStats { Strength, Dexterity, Wisdom, Dodge } // dummies
    public enum SpecialAchievements { SkillMastery_I, SkillMastery_II, SkillMastery_III, Treasurer}  // ideas for achievemnts (ex. Treasurer means collecting certain big amount of silver coins)
    public enum SkillTraining { Reflexes, UnitTraining }  // ideas for training player's heroes or units or city according to player's skills in mini games
    public enum Items { Sword, Axe, Orb}  // enum for the example, there will be a big tree for the items, each with cost
    public enum Currencies { Silver, Gold, Ruby}
    public enum Rarity { Common, Rare, Epic, Mythic}  // fffffffffffffffffak
    public enum BuildingTypes { Spawner, Vendor, PVP, PVE, Training}

    // dummy
    public class PlayerUnits
    {
        
    }

    // dummy
    public class PlayerArmy
    {

    }

    // dummy
    public class PlayerHeroes
    {

    }

    public interface IPlayer
    {
        // Stats
        int ID { get; set; }
        int level { get; set; }
        int vipLevel { get; set; }  // from pay-to-win
        int xp { get; set; }
        float luck { get; set; }  // literally increase chances of good stuff to everything that has a luck multiplier on its random factor
        Mythology mythology { get; set; }
        ICollection<SpecialAchievements> achievements { get; set; }

        // Currencies
        int silver { get; set; }  // for easy stuff
        int gold { get; set; }  // not that easy to gain
        int rubies { get; set; }  // ultra premium tough to earn

        // Army
        int populationCapacity { get; }  // definitely private set, according to player level and vip and etc.
        int populationCapacityCalculator(int level, int vipLevel);
        ICollection<Units> units { get; }  // maybe private set better
        PlayerArmy army { get; set; }
    }

    #region AliveThingsReadyToDie
    public interface IUnit
    {
        int ID { get; set; }
        Mythology mythology { get; set; }
        int level { get; set; }
        int levelCapacity { get; set; }
        int basePower { get; set; }

        double unitPowerCalculator(int level, int basePower);
    }

    public interface IHero : IUnit
    {
        Rarity rarity { get; set; }

        ICollection<HeroStats> stats { get; set; }
        ICollection<HeroSkills> skills { get; set; }
    }

    public interface IArmy
    {
        int ID { get; set; }
        double moraleMultiplier { get; set; }
        ICollection<PlayerUnits> units { get; set; }
        ICollection<PlayerHeroes> heroes { get; set; }

        double armyPowerCalculator(ICollection<PlayerUnits> units, ICollection<PlayerHeroes> heroes);
    }
    #endregion

    #region Buildings
    public interface IBuildings
    {
        int ID { get; set; }
        string name { get; set; }  // ex. Barracks
        int levelUnlocked { get; set; }  // not all buildings are available from Level_1
        BuildingTypes type { get; set; }
    }
    
    public interface ISpawners: IBuildings
    {
        ICollection<Units> units { get; set; }

        // For each unit available in building (each building may have more than one type of units to spawn)
        float spawnTimeCalculator(Units unit); // other type than float for Time?
        float cooldownTimeCalculator(Units unit);
        int spawnLimit(Units unit); // different according to unit
    }

    public interface IVendors: IBuildings
    {
        Random rnd(); // randomness for the available for sale items
        ICollection<Items> items { get; }  // private set
        int numberOfItemsForSale { get; set; }  // not all vendors have the same number of items for sale
        float cooldownTimeToChangeItems { get; set; }
        bool everythingWasSold { get; set; }  // idea, if everything is bought by the player, he gets an extra something

        // defining the items offered
        ICollection<Items> ItemGenerator(float PlayersLuck);  // player's luck increases the small chances of the good stuff
    }

    public interface IPVP : IBuildings
    {
        // needs brainstorming
    }

    public interface IPVE : IBuildings
    {
        // needs brainstorming
    }

    public interface ITrainingBootcamps : IBuildings
    {
        // needs brainstorming
    }
    #endregion

    public interface IItems
    {
        int ID { get; set; }
        Currencies currency { get; set; }
        int vendorCost { get; set; }  // according to self currency, it is going to be pre-fixed
        int sellProfit { get; set; }  // same here, pre-fixed
        Rarity rarity { get; set; }

        // make room for enchantment
        // make room for crafting
        // note that not all items are sold in vendor shops, some are crafted, other are dropped
    }
}
