using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppClick : MonoBehaviour
{
    public Image img;

    public void ShowImage()
    {
        img.gameObject.SetActive(true);
    }
}
