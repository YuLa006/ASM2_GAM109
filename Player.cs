using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class Player
    {
        public string playerID;
        public string accountID;
        public string playerName;
        public int Level;
        public int Experience;
        public int health;
        public int mana;
        public string Class;
        public DateTime creationDate;

        public override string ToString()
        {
            return $"PlayerID: {playerID} AccountID: {accountID} PlayerName: {playerName} Level: {Level}" +
                $" Experience: {Experience} Health: {health} Mana: {mana} Class: {Class} CreationDate: {creationDate.ToString("yyyy-MM-dd")}";
        }


    }
}
