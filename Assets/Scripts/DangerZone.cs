using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        }

        if (checkpoint.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(Application.loadedLevel);
        }

    }

}
