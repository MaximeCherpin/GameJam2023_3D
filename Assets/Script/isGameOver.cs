using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public PlayerHealth health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health.health <= 0)
        {
            
        }
    }
}
