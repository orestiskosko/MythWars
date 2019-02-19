using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.BaseClasses
{
    public abstract class BaseItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        // maybe a collection of key value properties
    }
}
