using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public GameObject player;
    public GlobalMovement globalMovement;
    private Vector3 direction;
    private Vector3 movement;
    public float speed = 3f;

    void Start()
{
        direction = player.transform.position - transform.position;
        direction.Normalize();
        direction.y = globalMovement.speed;
        direction.z = 0;
        Debug.Log("x:" + direction.x + " y:" + direction.y + " z:" + direction.z);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = direction.x * speed * Time.deltaTime;
        movement.y = direction.y * Time.deltaTime;
        transform.position += movement;
        if (transform.position.y >= 6) {
            Destroy(gameObject);
        }
    }
}
