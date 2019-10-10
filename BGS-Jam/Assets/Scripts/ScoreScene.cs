using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScene : MonoBehaviour
{
    public string pP;
    private int score = 0;
    public string scene;
    
    public void IncreaseScore()
    {
        score += 1;
    }

    void Update()
    {
        if (score == 3)
        {
            PlayerPrefs.SetInt(pP, 1);
            SceneManager.LoadScene(scene);
        }
    }
}
