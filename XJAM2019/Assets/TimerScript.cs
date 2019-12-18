using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TimerScript : MonoBehaviour
{
    public Text TimerText;
    private float StartingTime;
    private float timer;
    void Start()
    {
        StartingTime = Time.time;
    }

    void Update()
    {
        //makes a timer in seconds and minutes

        float time = Time.time - StartingTime;

        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");

        TimerText.text = minutes + ":" + seconds;
    }
}
