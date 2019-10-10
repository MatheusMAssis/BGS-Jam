using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetChangeBackground : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float xVel, yVel;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        offset = new Vector2(xVel, yVel);
    }


    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
