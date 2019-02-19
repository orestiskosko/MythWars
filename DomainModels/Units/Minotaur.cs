using DomainModels.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Units
{
    public class Minotaur : BaseUnit
    {
        public Minotaur()
        {
            MaxHealth = 5000;
            AttackDamage = 80;
            AttackSpeed = 0.5F;
            Armor = 60;
            CurrentHealth = MaxHealth;
        }
    }
}
