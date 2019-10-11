using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpecificSound : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip wppSound;

    void Start()
    {
        audioSrc.PlayOneShot(wppSound);
    }
}
