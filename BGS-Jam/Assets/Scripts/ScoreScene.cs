using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreScene : MonoBehaviour
{
    public string pP;
    private int score = 0;
    public int maxScore;
    public Image popUp;
    public string nomeMensagem;

    private void Start()
    {
        PlayerPrefs.SetInt("IfVisited", 1);
    }

    public void IncreaseScore()
    {
        score += 1;
    }

    public void TesteScene()
    {
        if (pP == "Family")
        {
            PlayerPrefs.SetString("NomeMensagem","Mae");
            PlayerPrefs.SetString("TextoMensagem", "Oi, filho! Saiba que eu te amo nao importa o que aconteca!!");
        }
        else if (pP == "Social")
        {
            PlayerPrefs.SetString("NomeMensagem", "[GRUPO] Turma de 2001");
            PlayerPrefs.SetString("TextoMensagem", "Alo!! Sentimos sua falta :( Quando vamos nos ver de novo?");
        }
        else if (pP == "Future")
        {
            PlayerPrefs.SetString("NomeMensagem", "Filho");
            PlayerPrefs.SetString("TextoMensagem", "Voce e tudo e muito mais pra mim! O melhor pai do mundo!!");
        }
    }

    void Update()
    {
        TesteScene();

        if (score == maxScore)
        {
            PlayerPrefs.SetInt(pP, 1);
            popUp.gameObject.SetActive(true);
        }
    }
}
