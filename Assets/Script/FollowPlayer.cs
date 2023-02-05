using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Player player;
    public float smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        if (player.health.isAlive)
        {
            Vector3 playerPos = player.transform.position;
            if (player.transform.position.y - .5f <= transform.position.y)
                transform.position = new Vector3(transform.position.x, playerPos.y - .5f, transform.position.z);
        }
    }
}
