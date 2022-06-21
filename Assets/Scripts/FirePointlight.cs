using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointlight : MonoBehaviour
{
    public float offset;
    public float noiseSize;
    public float noiseSpeed;
    Light light;


    private void Awake()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        light.intensity = Mathf.PerlinNoise(Time.time * noiseSpeed, 10f)*noiseSize + offset;
    }
}
