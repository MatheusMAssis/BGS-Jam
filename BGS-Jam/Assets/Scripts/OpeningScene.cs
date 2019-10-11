using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScene : MonoBehaviour
{
    public Image img;

    public void DisableObject()
    {
        img.gameObject.SetActive(false);
    }
}
