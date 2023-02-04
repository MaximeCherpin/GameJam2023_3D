using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingParchemin : MonoBehaviour
{
    public Parchemin precedent;
    public Camera cam;
    public Parchemin parchemin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 precedentPos = precedent.transform.position;
        Vector3 pos = new Vector3(precedentPos.x, precedentPos.y - 14, precedentPos.z);
        if (precedentPos.y + 14 > cam.transform.position.y)
        {
            precedent = Instantiate(parchemin, pos, precedent.transform.rotation);
        }
    }
}
