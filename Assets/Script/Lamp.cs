using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public float incrementSpeed = 0.1f;
    private Vector3 _startingPosition;

    void Start()
    {
        _startingPosition = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(_startingPosition.x, _startingPosition.y + Time.time * incrementSpeed, _startingPosition.z);
    }
}
