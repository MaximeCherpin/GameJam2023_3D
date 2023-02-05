using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject ink_alive;
    public GameObject ink_alive2;
    public GameObject ink_alive3;
    public ScreenShake screenShake;

    private int number = 0;

    private GameObject[] ink_alive_array;
    // Start is called before the first frame update
    void Start()
    {

        number = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            Player player = other.gameObject.GetComponent<Player>();
            other.gameObject.GetComponent<PlayerHealth>().health -= 15;
            print("is dead!");
            ScreenShake.access.AddShake(0.2f);
            if (number == 0)
            {
                Instantiate(ink_alive, transform.position, Quaternion.Euler(0f, 0f, 0f));
            }
            else if (number == 1)
            {
                Instantiate(ink_alive2, transform.position, Quaternion.Euler(0f, 0f, 0f));
            }
            else if (number == 2)
            {
                Instantiate(ink_alive3, transform.position, Quaternion.Euler(0f, 0f, 0f));
            }
            Destroy(gameObject);
            //decrease scale
        }

    }
}
