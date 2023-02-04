using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        if (player.transform.position.y < pos.y)
        {
            this.transform.position = new Vector3(pos.x, pos.y - .03f, pos.z);
        }
    }
}
