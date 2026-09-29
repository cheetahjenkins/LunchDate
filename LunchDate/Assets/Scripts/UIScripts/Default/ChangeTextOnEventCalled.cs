using TMPro;
using UnityEngine;

public class ChangeTextOnEventCalled : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    
    public void SetText(EventData data)
    {
        textMeshProUGUI.SetText((string)data.data);
    }
}
