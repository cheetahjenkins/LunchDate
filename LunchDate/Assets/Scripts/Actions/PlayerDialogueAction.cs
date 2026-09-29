using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName ="PlayerDialogueAction")]
public class PlayerDialogueAction : PlayerAction
{
    public GameEvent OnPlayerTalk;
    public DialogueAttribute dialogueAttribute; 
    public override void PerformAction()
    {
        OnPlayerTalk.Broadcast(new EventData(data: dialogueAttribute));
        Debug.Log("PlayerActionPerformed");
    }
}
