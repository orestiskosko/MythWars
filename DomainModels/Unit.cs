using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public abstract class Unit : IUnit // Units can either: 1) Be minions and form an army, 2) Be heroes
    {
        int Id { get; set; }
        MythologyEnum Mythology { get; set; }
        int Level { get; set; }
        int LevelCapacity { get; set; }  // depending on User level
        int BasePower { get; set; }

        double IUnit.UnitPowerCalculator(int level, int basePower)
        {
            return 0;
        }
    }
}
