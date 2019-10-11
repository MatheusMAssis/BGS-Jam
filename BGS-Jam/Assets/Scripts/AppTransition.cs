using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AppTransition : MonoBehaviour
{
    public string scene;
    public Image img;

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void OpenImageApp()
    {
        img.gameObject.SetActive(true);
    }
}
