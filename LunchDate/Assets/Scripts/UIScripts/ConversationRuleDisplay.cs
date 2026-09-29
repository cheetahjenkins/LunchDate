using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConversationRuleDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void Display(EventData data)
    {
        string description = "";

        MeatMeProfileData profileData = (MeatMeProfileData)data.data;

        foreach(ConversationRule rule in profileData.conversationRules)
        {
            if (rule.isPositiveOutcome)
            {
                description += "Loves ";
            }
            else
            {
                description += "Hates ";
            }

            if(rule.conversationRuleName == ConversationRuleName.First)
            {
                description += rule.relevantAttributes[0].ToString() + " as first message";
            }
            if (rule.conversationRuleName == ConversationRuleName.Double)
            {
                description += rule.relevantAttributes[0].ToString() + " two times in a row";
            }
            if (rule.conversationRuleName == ConversationRuleName.Combination)
            {
                description += rule.relevantAttributes[0].ToString() + " and " + rule.relevantAttributes[1].ToString() + " combined";
            }
            if (rule.conversationRuleName == ConversationRuleName.Last)
            {
                description += rule.relevantAttributes[0].ToString() + " as last message";
            }

            description += "\n";
        }
        text.SetText(description);
    }
}
