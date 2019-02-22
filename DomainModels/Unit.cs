using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public abstract class Unit : IUnit // Units can either: 1) Be minions and form an army, 2) Be heroes
    {
        int Id { get; set; }
        string Name { get; set; }
        MythologyEnum Mythology { get; set; }
        MinionsEnum Type { get; set; }
        int Level { get; set; }
        int LevelCapacity { get; set; }  // depending on User level
        int BasePower { get; set; }
        int PopulationValue { get; set; }  // how much population it costs to the player

        double IUnit.UnitPowerCalculator(UnitType unitType, int userlevel, int unitLevel, int basePower) { throw new NotImplementedException(); }
    }
}
