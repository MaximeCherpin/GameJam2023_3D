using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float speed = 1f;
    public float speed_min = 1f;
    public float speed_max = 3f;
    public GameObject player;
    private Vector3 direction;
    private Vector3 movement;
    private float pause_cd;
    private float pause_cd_max;
    private float traveling_max;
    private float traveling;
    private bool ismoving;
    public GlobalMovement globalMovement;

    void Start()
    {
        speed = Random.Range(speed_min, speed_max);
        ismoving = true;
        traveling_max = 2;
        pause_cd_max = 1;
        direction = player.transform.position - transform.position;
        direction.y = globalMovement.speed;
        direction.z = 0;
    }

    void Update()
    {

        if (ismoving) {
            movement.x = direction.x * speed * Time.deltaTime;
            movement.y = direction.y * Time.deltaTime;
            transform.position += movement;
        }
        traveling += Time.deltaTime;
        // if (traveling >= traveling_max) {
        //     Debug.Log("stop moving");
        //     ismoving = false;
        // }
        if (!ismoving) {
            pause_cd += Time.deltaTime;
            if (pause_cd >= pause_cd_max) {
                ismoving = true;
                pause_cd = 0;
                traveling = 0;
            }
        }
    }
}
