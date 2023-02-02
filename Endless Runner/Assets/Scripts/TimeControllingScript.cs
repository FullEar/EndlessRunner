using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeControllingScript : MonoBehaviour
{
    public TMP_Text textTimer;

    private float timer = 0.0f;
    private bool isTimer = false;

    private void Update()
    {
        timer += Time.deltaTime;
        DisplayTime();
    }

    void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void Awake()
    {
        isTimer = true;
    }

    
}
