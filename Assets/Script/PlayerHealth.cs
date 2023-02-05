using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;

    private float cd_max = 1f;

    private float cd = 0f;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cd += Time.deltaTime;
        if (cd > cd_max)
        {
            cd = 0f;
            health-= 2;
        }
        if (health >= 100)
        {
            health = 100;
        }
        if (health <= 0)
        {
            health = 0;
        }
        // goyome's note : doesn't work as expected (health change the size of the root)s
        //float scale = (float)health / (float)maxHealth;
        //transform.localScale = new Vector3(scale, transform.localScale.y, transform.localScale.z);
            
        }
}
