using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public Player player;
    public float speed = 1f;

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousPosnotreal = Input.mousePosition;
        mousPosnotreal.z = 5.5f;
        Vector3 mousPos = cam.ScreenToWorldPoint(mousPosnotreal);
        float dir = (mousPos.x - player.transform.position.x);
        if (player.transform.position.x < 2.67 && player.transform.position.x > -2.31)
            player.controller.Move(new Vector3(dir * speed, -player.speed/2, 0) * Time.deltaTime);

    }
}
