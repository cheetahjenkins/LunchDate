using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueHistoryUI : MonoBehaviour
{
    public GameObject UI;
    public GameObject prefab;

    public List<Sprite> sprites;

    public void Clear(EventData data)
    {
        foreach(GameObject child in transform.GetComponentInChildren<Transform>())
        {
            Destroy(child.gameObject);
        }
    }

    public void Add(EventData data)
    {
        Debug.Log("Add Dialogue histry");
        if(data.data is DialogueAttribute)
        {
            DialogueAttribute attribute = (DialogueAttribute)data.data;

            GameObject clone = Instantiate(prefab,transform);
            GameObject icon = clone.transform.GetChild(0).GetChild(1).gameObject;
            Image image = icon.GetComponent<Image>();

            if(attribute == DialogueAttribute.Flirt)
            {
                image.sprite = sprites[0];
            }
            if (attribute == DialogueAttribute.SmallTalk)
            {
                image.sprite = sprites[1];
            }
            if (attribute == DialogueAttribute.Ignore)
            {
                image.sprite = sprites[2];
            }
            if (attribute == DialogueAttribute.Joke)
            {
                image.sprite = sprites[3];
            }
        }
    }
}
