using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.BaseClasses
{
    public abstract class BaseArmy
    {
        protected int Count { get; set; }
        protected ICollection<BaseUnit> Units { get; set; }
    }
}
