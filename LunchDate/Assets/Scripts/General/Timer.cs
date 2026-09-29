using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public UnityEvent functions;
    public float interval = 10;

    public bool active = true;

    private void Start()
    {
        StartCoroutine(StartTimer());
    }

    public IEnumerator StartTimer()
    {
        while (active)
        {
            yield return new WaitForSeconds(interval);
            functions.Invoke();
        }
    }
}
