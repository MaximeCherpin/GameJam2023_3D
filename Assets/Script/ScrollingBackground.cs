using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float incrementSpeed = 0.1f;
    private Material _material;
    private Vector2 _startingOffset;

    void Start()
    {
        _material = GetComponent<Renderer>().material;
        _startingOffset = _material.mainTextureOffset;
    }

    void Update()
    {
        _material.mainTextureOffset = new Vector2(_startingOffset.x, _startingOffset.y + Time.time * incrementSpeed);
    }
}
