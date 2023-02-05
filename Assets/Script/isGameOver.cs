using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController cam;
    public PlayerHealth health;
    private Vector3 _initialPos = new Vector3(-0.3f, 3.05f, -5.5f);
    public float speed = 0f;
    public float maxDist = 0f;
    private float _wait = 30f;
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 camPos = cam.transform.position;
        float dist = Vector3.Distance(camPos, _initialPos);
        if (!health.isAlive && camPos.y < _initialPos.y)
        {
            if (_wait > 0)
            {
                _wait -= 1;
            }
            else
            {
                print(dist * 100 / maxDist > 10);
                if (dist * 100 / maxDist > 10)
                {
                    cam.Move(new Vector3(0, speed, 0) * Time.deltaTime);
                    speed += 1;
                }
                else
                {
                    cam.Move(new Vector3(0, speed, -1) * Time.deltaTime);
                    speed -= 9;
                    if (speed <= 0)
                        speed = 1;
                }

            }
        }
        else
        {
            maxDist = dist;
        }
    }
}

