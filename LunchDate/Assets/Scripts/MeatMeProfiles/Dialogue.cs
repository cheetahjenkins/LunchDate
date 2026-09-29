using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    public DialogueSetting dialogueSetting;
    public string content;

    public enum DialogueSetting
    {
        Chat,
        Apartment,
    }
}

