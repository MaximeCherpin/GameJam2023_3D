using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideEnemy : MonoBehaviour
{
    public GameObject Ink_dead;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            playerHealth.health -= 15;
            Instantiate(Ink_dead, transform.position, transform.rotation);
        }
    }
}
