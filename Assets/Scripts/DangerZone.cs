using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    public Vector3 respawnPoint;


    void OnTriggerEnter(Collider checkpoint)
    {
        if (checkpoint.tag == "Checkpoint")
        {
            respawnPoint = checkpoint.transform.position;
        }

        if (checkpoint.gameObject.tag == "Reset")
        {
            transform.position = respawnPoint;
            Debug.Log("you stupid");
        }

        if (checkpoint.gameObject.tag == "Collapse")
        {
            DestroyObject(checkpoint.gameObject);        }
    }

}
