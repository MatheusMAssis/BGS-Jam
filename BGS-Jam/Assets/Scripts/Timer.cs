using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float aux = 60f;

    void Start()
    {
        timerText = timerText.GetComponent<TextMeshProUGUI>();    
    }

    void Update()
    {
        aux -= Time.deltaTime;
        timerText.text = Mathf.FloorToInt(aux).ToString();
    }
}
