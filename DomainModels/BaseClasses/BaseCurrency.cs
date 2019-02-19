using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.BaseClasses
{
    public abstract class BaseCurrency
    {
        public BaseCurrency(string name, CurrencyType type)
        {
            Name = name;
            Type = type;
        }

        protected string Name { get; set; }
        protected CurrencyType Type { get; set; }
    }
}
