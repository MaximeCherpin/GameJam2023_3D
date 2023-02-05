using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeHandler : MonoBehaviour
{
    public PlayerHealth health;

    public GameObject arbre0;
    public GameObject arbre1;
    public GameObject arbre2;
    public GameObject arbre3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!health.isAlive)
        {
            if (health.score >= 0 && health.score <= 100)
            {
                arbre0.SetActive(true);
            }
            if (health.score > 100 && health.score <= 200)
            {
                arbre1.SetActive(true);
            }
            if (health.score > 200 && health.score <= 350)
            {
                arbre2.SetActive(true);
            }
            if (health.score > 350)
            {
                arbre3.SetActive(true);
            }

        }
    }
}
