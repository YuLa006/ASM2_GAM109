using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class Item
    {
        public string iteamID;
        public string itemName;
        public string itemType;
        public string description;
        public int attackPower;
        public int defensePower;
        public int vaule;
        public string rarity;
        public string ownerPlayerID;

        public override string ToString()
        {
            return $"ItemID:{iteamID} ItemName:{itemName} ItemTypr:{itemType} Description:{description} AttackPower:{attackPower} DefensePower:{defensePower}" +
                $" Vaule:{vaule} Rarity:{rarity} OwnerPlayerID:{ownerPlayerID}";
        }
    }
}
