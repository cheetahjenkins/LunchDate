using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "MeatMeProfileData")]
public class MeatMeProfileData : ScriptableObject
{
    public string username;
    public Sprite photo;
    public Sprite deadPhoto; 

    public string description;

    public List<string> greetings;
    public List<string> positive;
    public List<string> negative;
    public List<string> death;
    public List<string> conversationSuccess;
    public List<string> conversationFail;

    public List<string> apartmentDialogues; 

    public List<ConversationRule> conversationRules;
}
