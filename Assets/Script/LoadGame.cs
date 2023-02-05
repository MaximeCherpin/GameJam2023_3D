using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public void OnButtonPressed ()
    {
        Application.LoadLevel("main");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
