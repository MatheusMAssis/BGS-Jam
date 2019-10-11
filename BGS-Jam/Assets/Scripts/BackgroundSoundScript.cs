using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSoundScript : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
