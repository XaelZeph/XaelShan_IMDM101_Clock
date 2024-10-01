using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;


    [SerializeField]
    Transform hoursPivot, minutePivot, secondPivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        var time = DateTime.Now;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        minutePivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        secondPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }

}
