using System.Linq.Expressions;
using UnityEngine;

public class IntTracker : MonoBehaviour
{
    public string valueName;

    public int maximum = 3;
    public int current = 3;

    public GameEvent valueAtZeroEvent;
    public GameEvent valueAtMaximumEvent; 
    public GameEvent valueChangedEvent;

    private void Update()
    {
        if(current <= 0)
        {
            if(valueAtZeroEvent != null)
            {
                valueAtZeroEvent.Broadcast(new EventData(sender: transform, recipient: transform));
            }
        }
    }
    
    public void BroadcastValueChanged()
    {
        if (valueChangedEvent == null) return;
        valueChangedEvent.Broadcast(new EventData(sender: transform, recipient: transform, data:current));
    }


    public void IncreaseValue(EventData data)
    {
        if (data.recipient != transform) return;
        current += (int)data.data;
        BroadcastValueChanged();
    }

    public void DecreaseValue(EventData data)
    {
        if (data.recipient != transform) return;
        current -= (int)data.data;
        BroadcastValueChanged();
    }

    public void IncreaseValue(int data)
    {
        current += data;
        BroadcastValueChanged();
    }

    public void DecreaseValue(int data)
    {
        current -= data;
        BroadcastValueChanged();
    }
}
