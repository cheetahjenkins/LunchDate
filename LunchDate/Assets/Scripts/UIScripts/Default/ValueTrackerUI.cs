using TMPro;
using UnityEngine;

public class ValueTrackerUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void UpdateText(EventData data)
    {
        print(data.data.ToString());
        text.SetText(data.data.ToString());
    }
}
