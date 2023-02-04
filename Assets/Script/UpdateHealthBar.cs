using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private int health;
    private int maxHealth;
    public float maxscale = 3f;
    void Start()
    {
    }
    void Update()
    {
        transform.localScale = new Vector3(1, maxscale * health / maxHealth, 1);
    }
}
