using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAll : MonoBehaviour
{
    public string scene;
    public GameObject popUp;

    void Start()
    {
        
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
