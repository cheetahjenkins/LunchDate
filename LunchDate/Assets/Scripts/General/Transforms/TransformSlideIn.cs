using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class TransformSlideIn : MonoBehaviour 
{
    public Vector3 initialPosition;
    public float offset;
    public Vector3 direction;

    public float duration = 1f;

    public float timeElapsed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
        StartCoroutine(Slide());
    }

    private void Update()
    {
        
    }

    public IEnumerator Slide()
    {
        transform.position += offset * direction;

        float timeElapsed = 0;

        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            float t = timeElapsed / duration;
            transform.position = Vector3.Lerp(transform.position, initialPosition, t);
            yield return null;
        }
        transform.position = initialPosition;
    }
}

public class RectSlideIn: MonoBehaviour
{
    public Vector3 initialPosition;
    public float offset;
    public Vector3 direction;

    public float duration = 1f;

    public float timeElapsed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
        StartCoroutine(Slide());
    }

    private void Update()
    {

    }

    public IEnumerator Slide()
    {
        transform.position += offset * direction;

        float timeElapsed = 0;

        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            float t = timeElapsed / duration;
            transform.position = Vector3.Lerp(transform.position, initialPosition, t);
            yield return null;
        }
        transform.position = initialPosition;
    }
}

