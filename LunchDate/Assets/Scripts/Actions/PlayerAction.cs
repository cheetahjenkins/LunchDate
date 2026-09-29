using UnityEngine;

public class PlayerAction : ScriptableObject, IAction
{
    public ActionType actionType;
    public GameEvent onActionPerformed;
    public string actionName;
    public virtual void PerformAction()
    {
        
    }
}
