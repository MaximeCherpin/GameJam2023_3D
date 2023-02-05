using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{
    public GameObject katana;
    public GameObject bonzai_tree;
    public GameObject lantern;
    public GameObject lampion;
    public GameObject wakizashi;
    public GameObject cup;

    private bool is_right = true;
    private int choice = 0;
    private float x = 0;
    private float y = 0;

    private float cd = 0;

    private float cd_max = 2;
    public float cd_max1 = 4;
    public float cd_max2 = 9;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        cd += Time.deltaTime;
        if (cd >= cd_max) {
            cd_max = Random.Range(cd_max1, cd_max2);
            y = transform.position.y;
            cd = 0;
            choice = Random.Range(0, 3);
            is_right = Random.Range(0, 2) == 0;
            if (is_right == true) {
                x = Random.Range(50, 80) / 10;
            }
            else {
                x = Random.Range(-80, -60) / 10;
            }
            if (choice == 0) {
                Quaternion rotation = katana.transform.rotation;
                Instantiate(katana, new Vector3(x, y, katana.transform.position.z), rotation);
            }
            else if (choice == 1) {
                Quaternion rotation = bonzai_tree.transform.rotation;
                Instantiate(bonzai_tree, new Vector3(x, y, bonzai_tree.transform.position.z), rotation);
            }
            else if (choice == 2) {
                Quaternion rotation = lantern.transform.rotation;
                rotation.z = Random.Range(0, 360);
                Instantiate(lantern, new Vector3(x, y, lantern.transform.position.z), rotation);
            }
            else if (choice == 3) {
                Quaternion rotation = lampion.transform.rotation;
                rotation.z = Random.Range(0, 360);
                Instantiate(lampion, new Vector3(x, y, lampion.transform.position.z), rotation);
            }
            else if (choice == 4) {
                Quaternion rotation = wakizashi.transform.rotation;
                rotation.z = Random.Range(0, 360);
                Instantiate(wakizashi, new Vector3(x, y, wakizashi.transform.position.z), rotation);
            }
            else if (choice == 5) {
                Quaternion rotation = cup.transform.rotation;
                rotation.z = Random.Range(0, 360);
                Instantiate(cup, new Vector3(x, y, cup.transform.position.z), rotation);
            }
        }
    }
}
