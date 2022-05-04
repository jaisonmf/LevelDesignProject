using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collapse2 : MonoBehaviour
{
    public GameObject objectToMove;

    void OnTriggerEnter(Collider fall2)
    {
        if (fall2.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("Collapse2");
            Destroy(gameObject);
        }
    }

}