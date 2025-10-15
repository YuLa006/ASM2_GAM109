using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class Quest
    {
        public string QuestID;
        public string QuestName;
        public string Description;
        public string QuesType;
        public string difficulty;
        public string experienceReward;
        public string GoldReward;
        public string status;
        public string requiredItemID;
        public string rewardItemID;
        public string AssigneePlayerID;

        public override string ToString()
        {
            return $"QuestID:{QuestID} QuestName:{QuestName} Description:{Description} QuestType:{QuesType} Difficulty:{difficulty} ExperienceReward:{experienceReward}" +
                $" GoldReward:{GoldReward} Status:{status} RequiredItemID:{requiredItemID} RewardItemID:{rewardItemID} AssigneePlayerID:{AssigneePlayerID}";
        }
    }
}
