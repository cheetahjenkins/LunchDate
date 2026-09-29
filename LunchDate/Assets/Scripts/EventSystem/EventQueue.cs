using System.Collections;
using UnityEngine;

public class EventQueue : MonoBehaviour
{
    public float delay = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Begin()
    {
        yield return new WaitForSeconds(delay);
    }
}
