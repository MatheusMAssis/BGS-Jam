using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    //Texto
    public TextMeshProUGUI textDisplay;
    private int index;
    public float typingSpeed;

    public Image fade;

    public string scene;

    [TextArea]
    public string[] sentences;

    //Butao
    public GameObject continueButton;

    void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void ClickToPass()
    {
        if (Input.GetMouseButtonDown(0))
        {
            typingSpeed = 0.01f;
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            //SceneManager.LoadScene(scene);
            fade.gameObject.SetActive(true);
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        ClickToPass();
    }
}