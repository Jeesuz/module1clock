using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockScript : MonoBehaviour
{

    private const float hourstoDegrees = 360f / 12f;
    private const float minutestoDegrees = 360f / 60f;
    private const float secondstoDegrees = 360f / 60f;

    public Transform hourpivot, minutepivot, secondpivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hourpivot.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * hourstoDegrees, 0f);
        minutepivot.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * minutestoDegrees, 0f);
        secondpivot.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * secondstoDegrees, 0f);
    }
}
