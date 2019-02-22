using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Item
    {
        int ID { get; set; }
        CurrenciesEnum currencyRequired { get; set; }
        int vendorCost { get; set; }  // according to self currency, it is going to be pre-fixed
        int sellProfit { get; set; }  // same here, pre-fixed
        RarityEnum rarity { get; set; }

        // make room for enchantment
        // make room for crafting
        // note that not all items are sold in vendor shops, some are crafted, other are dropped
    }
}
