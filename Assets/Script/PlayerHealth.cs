using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 200;
    public float maxHealth = 300;
    public bool isAlive = true;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
            health -= .3f;
        if (health < 0)
        {
            isAlive = false;
        }

    }
}
