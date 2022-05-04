using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{

    void OnTriggerEnter(Collider rock)
    {
        if (rock.gameObject.tag == "Reset")
        {
            Destroy(this);
        }
    }

}
