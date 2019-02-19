using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.BaseClasses
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Story { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Dodge { get; set; }

        public ICollection<BaseSkill> Skills { get; set; }
    }
}
