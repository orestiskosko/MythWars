using DomainModels.BaseClasses;
using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Currencies
{
    public class GoldCurrency : BaseCurrency
    {
        public GoldCurrency(string name) : base(name, CurrencyType.Gold) { }
    }
}
