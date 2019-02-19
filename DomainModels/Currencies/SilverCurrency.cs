using DomainModels.BaseClasses;
using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Currencies
{
    public class SilverCurrency : BaseCurrency
    {
        public SilverCurrency(string name) : base(name, CurrencyType.Silver) { }
    }
}
