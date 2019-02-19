using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.BaseClasses
{
    public abstract class BaseUnit
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Story { get; set; }

        public BaseMythology Mythology { get; set; }

        public int MaxHealth { get; set; }
        public int AttackDamage { get; set; }
        public float AttackSpeed { get; set; }
        public int Armor { get; set; }

        public double CurrentHealth { get; set; }
    }
}
