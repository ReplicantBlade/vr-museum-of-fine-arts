using UnityEngine;

public class SwitchHandler : MonoBehaviour
{
    [SerializeField] private Transform handle;
    [SerializeField] private GameObject light;
    private bool isOn;

    public void ToggleSwitch()
    {
        if (isOn)
        {
            light.SetActive(false);
            handle.Rotate(-45f, 0f, 0f);
            isOn = false;
        }
        else
        {
            light.SetActive(true);
            handle.Rotate(45f, 0f, 0f);
            isOn = true;
        }
    }
}
