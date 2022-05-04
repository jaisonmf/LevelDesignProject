using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collapse : MonoBehaviour
{
    public GameObject objectToMove;


    void OnTriggerEnter(Collider fall)
    {
        if (fall.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("Collapse");
            Destroy(gameObject);
        }
    }

}


