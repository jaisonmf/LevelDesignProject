using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DangerZone : MonoBehaviour
{
    public Vector3 respawnPoint;
    public Camera lose;
    public Camera player;

    public Text textField1;
    public Text textField2;
    public Text textField3;
    public GameObject gameover;
    public GameObject character;


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
            player.enabled = false;
            lose.enabled = true;
            textField1.gameObject.SetActive(true);
            textField2.gameObject.SetActive(true);
            textField3.gameObject.SetActive(true);
            gameover.GetComponent<GameOver>().restart();
            character.SetActive(false);   

        }   


    }


}
