using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.BaseClasses
{
    public abstract class BasePlayer
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public BaseMythology Mythology { get; set; }
        public BaseHero Hero { get; set; }
        public BaseArmy Army { get; set; }


    }
}
