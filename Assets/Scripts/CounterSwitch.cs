using UnityEngine;
using System.Collections;

public class CounterSwitch : MonoBehaviour
{
    public GameObject Target;
    public string Event = "Activate";
    public int ActivationCount = 1;

    private int count = 0;

    public void Activate()
    {
        count++;
        if (count == ActivationCount)
        {
            Target.SendMessage(Event);
        }
    }

    public void Deactivate()
    {
        count--;
    }
}
