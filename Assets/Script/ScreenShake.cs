using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ScreenShake : MonoBehaviour
{
    public static ScreenShake access;
    
    // Start is called before the first frame update
    public bool shaking = false;
    public float shakeAmount = 0.2f;
    public float decreaseFactor = 1f;
    PostProcessVolume pp;
    private Grain myGrain;

    void Awake()
    {
        access = this;
        pp = GetComponentInChildren<PostProcessVolume>();
        myGrain = pp.sharedProfile.GetSetting<Grain>();
        myGrain.enabled.Override(true);
        myGrain.intensity.Override(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (shaking == false && shakeAmount > 0)
            StartCoroutine(Shaking());
    }

    IEnumerator Shaking()
    {
        while (shakeAmount >= 0)
        {
            transform.localPosition = Random.insideUnitSphere * shakeAmount;
            shakeAmount -= Time.deltaTime * decreaseFactor;
            myGrain.intensity.Override(shakeAmount);
            yield return null;
        }
        ResetCamera();
    }

    void ResetCamera()
    {
        transform.localPosition = Vector3.zero;
        myGrain.intensity.Override(0);
        shaking = false;
    }

public void AddShake(float amount)
    {
        if (amount > shakeAmount) shakeAmount = amount;
    }
}
