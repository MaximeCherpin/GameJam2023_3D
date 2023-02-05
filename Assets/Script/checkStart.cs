using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject to_destroy;
    public GameObject to_anim;
    public Player player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            to_destroy.SetActive(false);
            to_anim.SetActive(true);
            player.start = true;
        }
    }
}
