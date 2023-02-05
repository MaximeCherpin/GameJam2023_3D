using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float speed = 1f;
    public float speed_min = 0.2f;
    public float speed_max = 1f;
    public GameObject player;
    private Vector3 direction;
    private Vector3 movement;
    private float pause_cd;
    private float traveling;
    private bool ismoving;
    private float alive_time = 0f;
    public GlobalMovement globalMovement;

    void Start()
    {
        speed = Random.Range(speed_min, speed_max);
        ismoving = true;
        direction = player.transform.position - transform.position;
        direction.z = 0;
        transform.rotation = Quaternion.LookRotation(direction);
    }
    void Update()
    {

        if (ismoving) {
            movement.x = direction.x * speed * Time.deltaTime;
            transform.position += movement;
        }
        alive_time += Time.deltaTime;
        traveling += Time.deltaTime;
        if (alive_time >= 8) {
            Destroy(gameObject);
        }
        if (transform.position.x < -5 || transform.position.x > 5) {
            Destroy(gameObject);
        }
    }
}
