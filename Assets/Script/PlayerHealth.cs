using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float maxHealth = 100;
    public bool isAlive = true;

    public float score = 0f;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth)
            health = maxHealth;
        if (isAlive)
        {
            health -= 6f * Time.deltaTime;
            score += 6f * Time.deltaTime;
        }

        if (health < 0)
        {
            isAlive = false;
        }
        // if mouse click and isAlive == false, then restart the game
        if (Input.GetMouseButtonDown(0) && !isAlive)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}
