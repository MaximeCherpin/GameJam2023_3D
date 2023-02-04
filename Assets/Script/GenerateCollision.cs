using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCollision : MonoBehaviour
{
    public GameObject collision;
    private float spawn_cd;
    public float spawn_cd_max;
    public float min_x;
    public float max_x;
    public float min_y;
    public float max_y;
    void Start()
    {
        spawn_cd = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        spawn_cd += Time.deltaTime;
        if (spawn_cd >= spawn_cd_max) {
            spawn_cd = 0;
            float x = Random.Range(min_x, max_x);
            float y = transform.position.y;
            Vector3 pos = new Vector3(x, y, 0);
            Quaternion rotation = Quaternion.Euler(90f, 0f, 0f);
            Instantiate(collision, pos, rotation);
        }
    }
}
