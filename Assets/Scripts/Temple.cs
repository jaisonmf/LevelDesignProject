using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Temple : MonoBehaviour
{
    public GameObject objectToMove;
    public Text textField1;
    public Text textField2;
    public Camera player;
    public Camera win;
    private bool won = false;
    public GameObject character;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("temple");
            player.enabled = false;
            win.enabled = true;
            textField1.gameObject.SetActive(true);
            textField2.gameObject.SetActive(true);
            won = true;
            character.gameObject.SetActive(false);


        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && won == true)
        {
            Application.Quit();
        }
    }
}
