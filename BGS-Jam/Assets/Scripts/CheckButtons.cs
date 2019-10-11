using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CheckButtons : MonoBehaviour
{
    public string scene;
    public Button family;
    public Button social;
    public Button future;
    public Image familyIm;
    public Image socialIm;
    public Image futureIm;
    public GameObject notification;
    public TextMeshProUGUI nomeTexto;
    public TextMeshProUGUI mensagemTexto;

    private void Start()
    {
        nomeTexto = nomeTexto.GetComponent<TextMeshProUGUI>();
        mensagemTexto = mensagemTexto.GetComponent<TextMeshProUGUI>();

        if (PlayerPrefs.GetInt("IfVisited") == 1)
        {
            nomeTexto.text = PlayerPrefs.GetString("NomeMensagem");
            mensagemTexto.text = PlayerPrefs.GetString("TextoMensagem");
            notification.SetActive(true);
        }
    }

    public void DisableButton()
    {
        if (PlayerPrefs.GetInt("Family") == 1)
        {
            family.interactable = false;
            familyIm.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Social") == 1)
        {
            social.interactable = false;
            socialIm.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Future") == 1)
        {
            future.interactable = false;
            futureIm.gameObject.SetActive(true);
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
