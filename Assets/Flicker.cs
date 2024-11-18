using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public Light F;

    // Start is called before the first frame update
    void Start()
    {
        F = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
    
       float brightness = 5*Mathf.PerlinNoise(Time.timeSinceLevelLoad, Time.timeSinceLevelLoad);
    
        F.intensity = brightness; 
}}
