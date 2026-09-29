using UnityEngine;

[CreateAssetMenu(fileName = "EventDataScriptableObjectStringValue", menuName = "Scriptable Objects/EventDataScriptableObjectStringValue")]
public class EventDataScriptableObjectStringValue : EventDataScriptableObject
{
    public string data;
    public override object GetData()
    {
        return data;
    }
}
