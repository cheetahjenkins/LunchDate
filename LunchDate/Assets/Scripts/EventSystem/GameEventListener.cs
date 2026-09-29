using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;

    [System.Serializable]
    public class CustomEvent : UnityEvent<EventData>{ }

    public CustomEvent response;

    private void OnEnable()
    {
        gameEvent.AddListener(this);
    }

    private void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }

    public void Respond(EventData data)
    {
        response.Invoke(data);
    }
}
