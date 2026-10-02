using System;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameEvent onVictimTalk;
    public MeatMeProfileData profileData;
    public int currentDialogueIndex = 0;

    public List<DialogueAttribute> ConversationHistory = new List<DialogueAttribute>();
    public int maxConversationLength = 5;

    public GameEvent onDialogueFail;
    public GameEvent onDialogueSuccess;

    public GameObject suspictionMeter;

    public GameEvent onVictimRespondPositive;
    public GameEvent onVictimRespondNegative;
    public GameEvent onVictimRespondConversationSuccess;
    public GameEvent onVictimRespondConversationFail;

    public GameEvent onVictimDeathDialogue;

    public GameEvent onMoveToKitchen;

    public int suspicionModifier = 60;

    public void AddToConversationHistory(EventData data)
    {
        
        ConversationHistory.Add((DialogueAttribute)data.data);
    }

    public void ResetAll(EventData data)
    {
        currentDialogueIndex = 0;
        ConversationHistory.Clear();
    }

    public void ChangeProfileData(EventData data)
    {
        if(data.data is MeatMeProfileData)
        {
            profileData = data.data as MeatMeProfileData;
        }
    }

    public void VictimRespond(bool outcome)
    {
        if (outcome == true)
        {
            onVictimRespondPositive.Broadcast(new EventData(data: profileData.positive[UnityEngine.Random.Range(0,profileData.positive.Count - 1)]));
        }
        else 
        {
            onVictimRespondNegative.Broadcast(new EventData(data: profileData.negative[UnityEngine.Random.Range(0, profileData.negative.Count - 1)]));
        }
    }

    public void CheckRules()
    {
        if (currentDialogueIndex == maxConversationLength - 1)
        {
            print("moving to kitchen");
            onMoveToKitchen.Broadcast(new EventData(data: profileData.apartmentDialogues[0]));
            ResetAll(new EventData());
            return;
        }

        int fails = 0;

        foreach(ConversationRule rule in profileData.conversationRules)
        {
            if(rule.conversationRuleName == ConversationRuleName.First)
            {
                if(First(rule.relevantAttributes[0], rule.isPositiveOutcome) == false)
                {
                    fails++;
                }
            }
            if (rule.conversationRuleName == ConversationRuleName.Double)
            {
                if(Double(rule.relevantAttributes[0], rule.isPositiveOutcome) == false)
                {
                    fails++;
                }
            }
        }
        if(fails == 0)
        {
            VictimRespond(true);
            onDialogueSuccess.Broadcast(new EventData(recipient: suspictionMeter.transform, data: suspicionModifier));
        }
        currentDialogueIndex++;
    }

    public bool Last(DialogueAttribute attribute, bool isPositiveOutcome)
    {
        if (ConversationHistory[maxConversationLength - 1] == attribute)
        {
            if (isPositiveOutcome)
            {
                //onDialogueSuccess.Broadcast(new EventData(recipient: suspictionMeter.transform, data: suspicionModifier));
                //VictimRespond(true);
            }
            else
            {
                onDialogueFail.Broadcast(new EventData(recipient: suspictionMeter.transform, data: suspicionModifier));
                VictimRespond(false);
                return false;
            }
        }
        return true;
    }

    public bool First(DialogueAttribute attribute, bool isPositiveOutcome)
    {
        if (currentDialogueIndex == 0)
        {
            if (ConversationHistory[0] == attribute)
            {
                if (isPositiveOutcome)
                {
                    //onDialogueSuccess.Broadcast(new EventData(recipient: suspictionMeter.transform, data: suspicionModifier));
                    //VictimRespond(true);
                }
                else
                {
                    onDialogueFail.Broadcast(new EventData(recipient: suspictionMeter.transform, data: suspicionModifier));
                    VictimRespond(false);
                    return false;

                }
            }
        }
        
        return true;
    }

    public bool Double(DialogueAttribute attribute, bool isPositiveOutcome)
    {
        if (currentDialogueIndex != 0)
        {
            if (ConversationHistory[ConversationHistory.Count - 1] == attribute && ConversationHistory[ConversationHistory.Count - 2] == attribute)
            {

                if (isPositiveOutcome)
                {
                    //onDialogueSuccess.Broadcast(new EventData(recipient: suspictionMeter.transform, data: 1));
                    //VictimRespond(true);
                }
                else
                {
                    onDialogueFail.Broadcast(new EventData(recipient: suspictionMeter.transform, data: 1));
                    VictimRespond(false);
                    return false;
                }
            }
        }
        return true;
    }

    //public void Combination(DialogueAttribute attributeOne, DialogueAttribute attributeTwo)
    //{
    //    if (ConversationHistory[ConversationHistory.Count - 1] == attributeOne && ConversationHistory[ConversationHistory.Count - 2] == attributeTwo)
    //    {
    //        onDialogueFail.Broadcast(new EventData());
    //    }
    //    if (ConversationHistory[ConversationHistory.Count - 1] == attributeTwo && ConversationHistory[ConversationHistory.Count - 2] == attributeOne)
    //    {
    //        onDialogueFail.Broadcast(new EventData());
    //    }
    //}
}
