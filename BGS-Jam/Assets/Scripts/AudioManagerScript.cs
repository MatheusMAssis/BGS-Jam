using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip buttonSound;
    public AudioClip correctSound;
    public AudioClip deniedSound;
    public AudioClip completedSound;

    void Start()
    {
        audioSrc = audioSrc.GetComponent<AudioSource>();
    }
    
    public void PlayButtonSound()
    {
        audioSrc.PlayOneShot(buttonSound);
    }

    public void PlayCorrectSound()
    {
        audioSrc.PlayOneShot(correctSound);
    }

    public void PlayDeniedSound()
    {
        audioSrc.PlayOneShot(deniedSound);
    }

    public void PlayCompletedSound()
    {
        audioSrc.PlayOneShot(completedSound);
    }
}
