using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayMusic : MonoBehaviour
{
    public AudioSource musicSource;

    void OnTriggerEnter(Collider other)
    {
        if (musicSource != null && !musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (musicSource != null && musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }
}

