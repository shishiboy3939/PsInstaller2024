using UnityEngine;
using System.Collections;

public class DisplayChange : MonoBehaviour
{

    void Start()
    {
        int maxDisplayCount = 3;
        for (int i = 0; i < maxDisplayCount && i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }
    }
}