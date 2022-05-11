using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;

    [SerializeField] private string openAnimationName = "keys";
  


    public void PlayAnimation()
    {
        GetComponent<Animator>().SetTrigger("pickup");
    }

}
