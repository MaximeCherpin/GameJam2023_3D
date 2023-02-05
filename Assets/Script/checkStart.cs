using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkStart : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public Player player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("je lcique");
            animator.SetBool("start", true);
            player.start = true;
        }
    }
}
