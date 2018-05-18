using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour {

    //the space of rotation between watch clock ticks (30 degrees)
    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;

    //transformer for the clock hands
    public Transform hoursTransform, minutesTransform, secondsTransform;

    //determine smooth flow of seconds hand or not
    public bool continuous;

    private void Awake()
    {
        //Debug.Log("Test");
        //Debug.Log(Time.time);

        Debug.Log(DateTime.Now.Hour);

        //grabs spinning position of hour arm
        // Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);

        //current time stored in a variable
        DateTime time = DateTime.Now;

        //attach it to the local rotation of hour transform
        hoursTransform.localRotation= Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (continuous) {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    // Update is called once per frame
    void UpdateContinuous()
    {
        //current time stored in a variable
        TimeSpan time = DateTime.Now.TimeOfDay;

        //attach it to the local rotation of hour transform
        hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
    }

    // Update is called once per frame
    void UpdateDiscrete()
    {

        //current time stored in a variable
        DateTime time = DateTime.Now;

        //attach it to the local rotation of hour transform
        hoursTransform.localRotation = Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
    }

}
