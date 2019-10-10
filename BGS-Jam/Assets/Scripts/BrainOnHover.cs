using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class BrainOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI textScene;
    public string scene;

    void Start()
    {
        textScene = textScene.GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        textScene.text = scene;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textScene.text = "";
    }
}
