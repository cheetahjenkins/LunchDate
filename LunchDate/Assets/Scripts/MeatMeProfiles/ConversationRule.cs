using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ConversationRule")]
public class ConversationRule : ScriptableObject
{
    public bool isPositiveOutcome = false;
    public ConversationRuleName conversationRuleName;
    public List< DialogueAttribute> relevantAttributes = new List< DialogueAttribute>();
}

public enum ConversationRuleName
{
    First,
    Last,
    Double,
    Combination
}
