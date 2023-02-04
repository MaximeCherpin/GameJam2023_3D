using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class generateMap : MonoBehaviour
{
    // Start is called before the first frame update
    public Parchemin precedent;
    public Parchemin parchemin;
    public Camera cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posPrecedent = precedent.transform.position;
        Vector3 position = new Vector3(posPrecedent.x, posPrecedent.y - 14, posPrecedent.z);
        Quaternion rot = precedent.transform.rotation;
        if (precedent.transform.position.y > cam.transform.position.y)
        {
            precedent = Instantiate(parchemin, position, rot);
            
        }
    }
}
