using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1f;
    public CharacterController controller;
    public PlayerHealth health;
    public TrailRenderer trail;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        trail.widthMultiplier = 1.3f * health.health / health.maxHealth;
    }
}
