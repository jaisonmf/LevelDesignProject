using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour
{
    public GameObject objectToMove;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("loser");
            objectToMove.GetComponent<Animator>().SetTrigger("temple");
            
        }
    }

}
