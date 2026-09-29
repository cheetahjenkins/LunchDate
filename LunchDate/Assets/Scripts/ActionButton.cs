using TMPro;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
    public PlayerAction action;
    public TextMeshProUGUI description;

    private void Update()
    {
        description.SetText(action.actionName);
    }

    public void OnClick()
    {
        action.PerformAction();
    }
}
