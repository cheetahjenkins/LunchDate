using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CallEventOnTriggerEnter2D : MonoBehaviour
{
    public GameEvent gameEvent;

    public string onlyCollideWithTag;

    public EventDataScriptableObject dataContainer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(dataContainer != null)
        {
            if (onlyCollideWithTag == null)
            {
                gameEvent.Broadcast(new EventData(sender: transform, recipient: collision.transform, data: dataContainer.GetData()));
            }
            else if (collision.gameObject.tag == onlyCollideWithTag)
            {
                print(dataContainer.GetData());
                gameEvent.Broadcast(new EventData(sender: transform, recipient: collision.transform, data: dataContainer.GetData()));
            }
            return;
        }


        if(onlyCollideWithTag == null)
        {
            gameEvent.Broadcast(new EventData(sender: transform, recipient: collision.transform));
        }
        else if(collision.gameObject.tag == onlyCollideWithTag) 
        {
            gameEvent.Broadcast(new EventData(sender: transform, recipient: collision.transform));
        }
    }
}
