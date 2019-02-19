using DomainModels.BaseClasses;
using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Currencies
{
    public class BronzeCurrency : BaseCurrency
    {
        public BronzeCurrency(string name) : base(name, CurrencyType.Bronze) { }

    }
}
