using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkIsAlive : MonoBehaviour
{
    private float alive = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        if (alive >= 2f) {
            Destroy(gameObject);
        }
    }
}
