using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "event", menuName = "Scriptable Objects/event")]
public class GameEvent : ScriptableObject
{
    public List<GameEventListener> listeners = new List<GameEventListener>();

    public void Broadcast(EventData data)
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].Respond(data);
        }
    }

    public void AddListener(GameEventListener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }
    public void RemoveListener(GameEventListener listener)
    {
        if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}
