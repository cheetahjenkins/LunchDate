using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageOnEventCalled : MonoBehaviour
{
    public Image image;

    public void SetSprite(EventData data)
    {
        image.sprite = (Sprite)data.data;
    }
}
