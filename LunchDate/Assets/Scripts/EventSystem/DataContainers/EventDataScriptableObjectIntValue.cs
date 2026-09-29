using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "EventDataScriptableObjectIntValue", menuName = "Scriptable Objects/EventDataScriptableObjectIntValue")]
public class EventDataScriptableObjectIntValue : EventDataScriptableObject
{
    public int value = 1;

    public override object GetData()
    {
        return value;
    }
}
