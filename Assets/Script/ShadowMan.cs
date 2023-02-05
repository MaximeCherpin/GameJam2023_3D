using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMan : MonoBehaviour
{
    public float incrementSpeed = 0.1f;
    private Vector3 _startingPosition;
    public Player player;
    void Start()
    {
        _startingPosition = transform.position;
    }

    void Update()
    {
        if (player.start)
        {
            transform.position = new Vector3(_startingPosition.x + Time.time * incrementSpeed, _startingPosition.y,
                _startingPosition.z);
            if (_startingPosition.x + Time.time * incrementSpeed >= 20)
                Destroy(gameObject);
        }
    }
}
