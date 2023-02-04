using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkMove : MonoBehaviour
{
    public GlobalMovement globalMovement;
    private Vector3 direction;
    private Vector3 movement;
    void Start()
    {
        direction.y = globalMovement.speed;
    }
    void Update()
    {
        movement = direction * Time.deltaTime;
        //transform.position += movement;
    }
}
