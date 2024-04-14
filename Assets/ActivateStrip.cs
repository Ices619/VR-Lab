using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStrip : MonoBehaviour
{
    [SerializeField] GameObject ActiveStrip;

    private void Start()
    {
        ActiveStrip.SetActive(false);
        GameEvents.current.eventCradleActive += Activate;
        GameEvents.current.eventCradleDeactive += Deactivate;

    }

    private void Activate()
    {
        ActiveStrip.SetActive(true);
    }

    private void Deactivate()
    {
        ActiveStrip.SetActive(false);
    }


}
