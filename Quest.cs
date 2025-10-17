using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class Quest
    {
        public string questID;
        public string questName;
        public string description;
        public string quesType;
        public string difficulty;
        public int experienceReward;
        public int goldReward;
        public string status;
        public string requiredItemID;
        public string rewardItemID;
        public string assigneePlayerID;

        public override string ToString()
        {
            return $"QuestID:{questID} QuestName:{questName} Description:{description} QuestType:{quesType} Difficulty:{difficulty} ExperienceReward:{experienceReward}" +
                $" GoldReward:{goldReward} Status:{status} RequiredItemID:{requiredItemID} RewardItemID:{rewardItemID} AssigneePlayerID:{assigneePlayerID}";
        }
    }
}
