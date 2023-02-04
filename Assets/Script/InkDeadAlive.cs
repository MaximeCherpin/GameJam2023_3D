using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkDeadAlive : MonoBehaviour
{
    public float alive_max;
    private float alive; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        if (alive >= alive_max) {
            Destroy(gameObject);
        }
    }
}
