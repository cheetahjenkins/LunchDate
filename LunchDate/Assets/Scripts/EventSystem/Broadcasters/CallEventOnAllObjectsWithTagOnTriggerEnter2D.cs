using System.Collections.Generic;
using UnityEngine;

public class CallEventOnAllObjectsWithTagOnTriggerEnter2D : MonoBehaviour
{
    public string targetTag;
    public GameEvent GameEvent;
    public EventDataScriptableObject data;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != targetTag) return;

        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag);

        foreach (GameObject target in targets)
        {
            GameEvent.Broadcast(new EventData(sender: transform, recipient: target.transform, data));
        }
    }
}
