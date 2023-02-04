using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public GlobalMovement globalMovement;
    private Vector3 direction;
    private Vector3 movement;

    void Start()
    {
        direction.y = globalMovement.speed;
    }

    // Update is called once per frame
    void Update()
    {
       movement = direction * Time.deltaTime;
       transform.position += movement;
       if (transform.position.y >= 6) {
           Destroy(gameObject);
       }
    }
}
