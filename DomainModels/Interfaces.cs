using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public interface IUser
    {
        int PopulationCapacityCalculator(int level, int townHallLevel,int vipLevel);
    }

    public interface IUnit
    {
        double UnitPowerCalculator(int level, int basePower);
    }
}
