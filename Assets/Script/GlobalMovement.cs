using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMovement : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        if (speed == null) {
            speed = 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
