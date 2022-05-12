using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private bool dead = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && dead == true)
        {
            SceneManager.LoadScene(Application.loadedLevel);
            dead = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && dead == true)
        {
            Application.Quit();
        }
    }

    public void restart()
    {
        dead = true;
    }
}
