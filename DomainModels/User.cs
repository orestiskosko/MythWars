using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class User : IUser
    {
        // Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Stats
        int Level { get; set; }
        int VipLevel { get; set; }  // from pay-to-win
        int Xp { get; set; }
        float Luck { get; set; }  // literally increase chances of good stuff to everything that has a luck multiplier on its random factor
        MythologyEnum Mythology { get; set; }
        ICollection<SpecialAchievementsEnum> Achievements { get; set; }

        // Currencies
        int Silver { get; set; }  // for easy stuff
        int Gold { get; set; }  // not that easy to gain
        int Rubies { get; set; }  // ultra premium tough to earn

        // Buildings
        int TownHallLevel { get; set; }

        // Units
        ICollection<Hero> Heroes { get; set; }
        ICollection<MinionsEnum> UnitsAvailableForUser { get; set; }  // not all users can have the same minions available

        // Army
        int ArmyId { get; set; }
        int PopulationCapacity { get; set; }

        // Quests
        ICollection<Quest> QuestsCompleted { get; set; }
        ICollection<Quest> QuestsNotCompleted { get; set; }

        int IUser.PopulationCapacityCalculator(int level, int townHallLevel, int vipLevel) { return 0; }
    }
}
