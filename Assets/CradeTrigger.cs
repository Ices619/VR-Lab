using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CradeTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cradleBall")
        {
            GameEvents.current.SetCradleActive();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cradleBall")
        {
            GameEvents.current.SetCradleDeactive();
        }
    }
}
