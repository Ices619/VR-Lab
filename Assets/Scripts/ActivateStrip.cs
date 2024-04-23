using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStrip : MonoBehaviour
{
    [SerializeField] GameObject ActiveStrip;
    public AudioSource src;
    public AudioClip sfx1;
    public AudioClip sfx2;

    private void Start()
    {
        ActiveStrip.SetActive(false);
        GameEvents.current.eventCradleActive += Activate;
        GameEvents.current.eventCradleDeactive += Deactivate;

    }

    private void Activate()
    {
        ActiveStrip.SetActive(true);
            src.clip = sfx1;
            src.Play();
    }

    private void Deactivate()
    {
        ActiveStrip.SetActive(false);
        src.clip = sfx2;
        src.Play();
    }


}
