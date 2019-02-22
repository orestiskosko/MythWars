using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public enum MythologyEnum { Greek, Egyptian, Norse }
    public enum UnitType { Hero, Minion }
    public enum MinionsEnum { Minotaur, Cyclops, Centaur, Phoenix, Sphinx, Mummy, Giant, Valkyrie, Viking }  // some dummy units ideas  {maybe separate later according to Mythology origin}
    public enum HeroesEnum { Achilles, Hercules, Ra, Anubis, Thor, Odin }  // same as above
    public enum HeroSkillsEnum { Stun, Bash, Kek, Lol }  // dummies
    public enum HeroStatsEnum { Strength, Dexterity, Wisdom, Dodge } // dummies
    public enum SpecialAchievementsEnum { SkillMastery_I, SkillMastery_II, SkillMastery_III, Treasurer }  // ideas for achievemnts (ex. Treasurer means collecting certain big amount of silver coins)
    public enum SkillTrainingEnum { Reflexes, UnitTraining }  // ideas for training player's heroes or units or city according to player's skills in mini games
    public enum ItemsEnum { Sword, Axe, Orb }  // enum for the example, there will be a big tree for the items, each with cost
    public enum CurrenciesEnum { Silver, Gold, Ruby }
    public enum RarityEnum { Common, Rare, Epic, Mythic }  // fffffffffffffffffak
    public enum BuildingTypesEnum { Spawner, Vendor, PVP, PVE, Training }
    public enum QuestsEnum { name1, name2, name3}
}
