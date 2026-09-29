using UnityEngine;

[System.Serializable]
public class EventData
{
    public Component sender;
    public Component recipient;
    public object data;

    public EventData(Component sender = null, Component recipient = null, object data = null)
    {
        this.sender = sender;
        this.recipient = recipient;
        this.data = data;
    }
}
