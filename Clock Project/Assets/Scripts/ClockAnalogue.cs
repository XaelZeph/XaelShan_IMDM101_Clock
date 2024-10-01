using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockAnalogue : MonoBehaviour
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
		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
		minutePivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
		secondPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

}
