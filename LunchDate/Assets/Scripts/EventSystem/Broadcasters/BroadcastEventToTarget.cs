using System.Linq.Expressions;
using UnityEngine;

public class BroadcastEventToTarget : MonoBehaviour
{
    public GameEvent gameEvent;
    public Transform target; 

    public void Broadcast()
    {
        gameEvent.Broadcast(new EventData(sender:transform, recipient:target));
    }
    public void Broadcast(EventData data)
    {
        gameEvent.Broadcast(new EventData(sender: transform, recipient: target));
    }
}
