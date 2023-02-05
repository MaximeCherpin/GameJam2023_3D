using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    // Start is called before the first frame update
    public float shake = 0f;
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;
    public Camera cam;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // print(shake);
        // if (shake > 0.1)
        // {
        //     print("make it shake");

        //     cam.transform.localPosition = Random.insideUnitSphere * shakeAmount;
        //     cam.transform.localPosition.z = -5.5f;
        //     cam.transform.localPosition.y = 1.30f;
        //      shake -= Time.deltaTime * decreaseFactor;
        // }
        // else
        // {
        //     shake = 0f;
        //     //cam.transform.localPosition = Vector3.zero;
        // }
    }
}
