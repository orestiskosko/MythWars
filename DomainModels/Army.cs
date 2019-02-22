using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Army : IArmy
    {
        int Id { get; set; }
        double MoraleMultiplier { get; set; }
        ICollection<Minion> Units { get; set; }
        ICollection<Hero> Heroes { get; set; }

        public double armyPowerCalculator(ICollection<Minion> units, ICollection<Minion> heroes) { throw new NotImplementedException(); }
    }
}
