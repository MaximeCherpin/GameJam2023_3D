using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Player player;
    public float smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        Vector3 playePos = player.transform.position;
        if (player.transform.position.y - 1 <= transform.position.y)
            transform.position = new Vector3(transform.position.x, playePos.y - 1, transform.position.z);
    }
}
