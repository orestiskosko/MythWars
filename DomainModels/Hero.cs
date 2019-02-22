using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Hero : Unit
    {
        float MoraleMultiplier { get; set; }
        RarityEnum rarity { get; set; }

        ICollection<HeroStatsEnum> stats { get; set; }
        ICollection<HeroSkillsEnum> skills { get; set; }
    }
}
