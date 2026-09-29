using System.Collections.Generic;
using UnityEngine;

public class DisableEnableGroup : MonoBehaviour
{
    public List<GameObject> group = new List<GameObject>();

    public void EnableGroup(EventData data)
    {
        foreach(GameObject go in group)
        {
            go.SetActive(true);
        }
    }
    public void DisableGroup(EventData data) 
    {
        foreach (GameObject go in group)
        {
            go.SetActive(false);
        }
    }
}
