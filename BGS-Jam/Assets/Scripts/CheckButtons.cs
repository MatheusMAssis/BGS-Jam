﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckButtons : MonoBehaviour
{
    public string scene;
    public Button family;
    public Button social;
    public Button future;

    public void DisableButton()
    {
        if (PlayerPrefs.GetInt("Family") == 1)
        {
            family.interactable = false;
        }

        if (PlayerPrefs.GetInt("Social") == 1)
        {
            social.interactable = false;
        }

        if (PlayerPrefs.GetInt("Future") == 1)
        {
            future.interactable = false;
        }
    }

    public void CheckWin()
    {
        if (PlayerPrefs.GetInt("Family") == 1 && PlayerPrefs.GetInt("Social") == 1 && PlayerPrefs.GetInt("Future") == 1)
        {
            SceneManager.LoadScene(scene);
        }
    }

    void Update()
    {
        CheckWin();
        DisableButton();
    }
}