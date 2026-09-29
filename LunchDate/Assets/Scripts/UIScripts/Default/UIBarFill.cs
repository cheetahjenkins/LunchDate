using UnityEngine;
using UnityEngine.UI;

public class UIBarFill : MonoBehaviour
{
    public Image bar;
    public IntTracker trackedValue;

    private void Update()
    {
        bar.fillAmount = ((float)trackedValue.current / (float)trackedValue.maximum);
    }
}
