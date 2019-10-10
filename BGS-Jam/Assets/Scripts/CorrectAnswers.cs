using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CorrectAnswers : MonoBehaviour
{
    public TextMeshProUGUI objective;

    void Start()
    {
        objective = objective.GetComponent<TextMeshProUGUI>();
    }

    public void RiskText()
    {
        objective.fontStyle = FontStyles.Strikethrough;
    }

    public void DisableButton()
    {
        GetComponent<Button>().interactable = false;
    }
}
