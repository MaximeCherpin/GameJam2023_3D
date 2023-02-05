using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOnCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 6) {
           Destroy(gameObject);
        }
    }
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().health += 5;
            //decrease scale
            transform.localScale -= new Vector3(0.025f, 0f, 0.025f);
        }
        if (transform.localScale.x <= 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
