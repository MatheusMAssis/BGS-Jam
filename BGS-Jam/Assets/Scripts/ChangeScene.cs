using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string scene;
    public AudioSource audioSrc;

    public void ChangeSceneTo()
    {
        SceneManager.LoadScene(scene);
    }

    public void CheckWin()
    {
        if (PlayerPrefs.GetInt("Family") == 1 && PlayerPrefs.GetInt("Social") == 1 && PlayerPrefs.GetInt("Future") == 1)
        {
            SceneManager.LoadScene("TextEndingScene");
        }
    }

    public void PlaySound()
    {
        audioSrc.GetComponent<AudioManagerScript>().PlayCompletedSound();
    }
}
