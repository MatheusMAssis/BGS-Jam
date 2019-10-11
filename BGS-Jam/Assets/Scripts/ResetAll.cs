using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAll : MonoBehaviour
{
    public string scene;
    public GameObject popUp;
    GameObject audioSrc;

    void Start()
    {
        audioSrc = GameObject.FindGameObjectWithTag("AudioSrc");
    }

    public void showPopUp()
    {
        popUp.SetActive(true);
    }

    public void hidePopUp()
    {
        popUp.SetActive(false);
    }

    public void resetAll()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(scene);
        Destroy(audioSrc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
