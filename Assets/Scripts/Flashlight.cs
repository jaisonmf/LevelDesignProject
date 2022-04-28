using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light light;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            light.enabled = !light.enabled;
        }
    }
}
