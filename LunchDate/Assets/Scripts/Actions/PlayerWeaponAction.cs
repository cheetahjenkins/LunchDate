using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName ="PlayerWeaponAction")]
public class PlayerWeaponAction : PlayerAction
{
    public override void PerformAction()
    {
        onActionPerformed.Broadcast(new EventData());
    }
}
