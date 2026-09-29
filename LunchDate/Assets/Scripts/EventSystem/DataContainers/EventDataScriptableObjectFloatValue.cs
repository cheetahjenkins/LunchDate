using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "EventDataScriptableObjectFloatValue", menuName = "Scriptable Objects/EventDataScriptableObjectFloatValue")]
public class EventDataScriptableFloatValue : EventDataScriptableObject
{
    public float value = 1;

    public override object GetData()
    {
        return value;
    }
}
