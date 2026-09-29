using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 offset;
    public void Spawn()
    {
        GameObject clone = Instantiate(prefab, transform.position, Quaternion.identity);
    }

    public void spawnAtSender(object data)
    {
        EventData eventData = (EventData)data;

        Vector3 position = transform.position;

        if(offset.magnitude > 0)
        {
            position += offset;
        }

        if (eventData.sender == transform)
        {
            GameObject clone = Instantiate(prefab, position, Quaternion.identity);
        }
    }
    public void spawnAtRecipient(object data)
    {
        EventData eventData = (EventData)data;

        Vector3 position = eventData.recipient.transform.position;

        if (offset.magnitude > 0)
        {
            position += offset;
        }

        if (eventData.recipient == transform)
        {
            GameObject clone = Instantiate(prefab, position, Quaternion.identity);
        }
    }


    public void SpawnAtPoint(EventData data)
    {
        Vector3 position = data.recipient.transform.position;

        if (offset.magnitude > 0)
        {
            position += offset;
        }
        
        GameObject clone = Instantiate(prefab, position, Quaternion.identity);
    }
}
