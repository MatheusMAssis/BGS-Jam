using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class Datetime : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    void Start()
    {
        timeText = timeText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = DateTime.Now.ToShortTimeString();
    }
}
