using System.Linq.Expressions;
using UnityEngine;

public class BroadcastEventFromSelf : MonoBehaviour
{
    public GameEvent gameEvent;

    public void Broadcast()
    {
        gameEvent.Broadcast(new EventData(sender:transform, recipient:transform));
    }
}
