using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorController : MonoBehaviour
{
    [SerializeField] private Animator doorAnim = null;

    [SerializeField] private string openAnimationName = "KeyPickup";
  


    public void PlayAnimation()
    {
        doorAnim.Play(openAnimationName, 0, 0.0f);
    }

}
