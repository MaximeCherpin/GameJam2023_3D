using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject player;
    private Vector3 direction;
    private Vector3 movement;
    public float traveling_time;
    public float traveling_cd;

    void Start()
    {
        traveling_time = 1;
        traveling_cd = 2;
        direction = player.transform.position - transform.position;
        direction.y = 0;
        direction.z = 0;
    }

    void Update()
    {
        if (traveling_time != 0) {
            movement = direction * speed * Time.deltaTime;
            transform.position += movement;
            traveling_time--;
        }
        else {
            
        }
    }
}
