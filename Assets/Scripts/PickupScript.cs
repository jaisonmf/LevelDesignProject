using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupScript : MonoBehaviour
{
    public Text textField;
    private bool fieldIsActive;

    void OnTriggerEnter(Collider text)
    {
        if (text.gameObject.tag == "Player")
        {
            textField.gameObject.SetActive(true);
            fieldIsActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && fieldIsActive == true)
        {
            ResetTextField();
        }
    }


    private void ResetTextField()
    {
        textField.gameObject.SetActive(false);
        fieldIsActive = false;
    }

}