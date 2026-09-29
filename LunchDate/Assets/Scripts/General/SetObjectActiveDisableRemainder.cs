using System.Collections.Generic;
using UnityEngine;

public class SetObjectActiveDisableRemainder : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();

    public void Navigate(int index)
    {
        foreach (GameObject thing in objects)
        {
            thing.SetActive(false);
            objects[index].SetActive(true);
        }
    }

    public void Navigate(EventData data)
    {
        foreach (GameObject thing in objects)
        {
            thing.SetActive(false);
            objects[(int)data.data].SetActive(true);
        }
    }
}
