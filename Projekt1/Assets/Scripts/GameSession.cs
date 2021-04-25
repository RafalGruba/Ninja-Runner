﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;
    private bool finished = false;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public void Timer()
    {
        if (finished == false)
        {
            int minutes = (int)(Time.timeSinceLevelLoad / 60f);
            int seconds = (int)(Time.timeSinceLevelLoad % 60f);
            int milliseconds = (int)(Time.timeSinceLevelLoad * 6f);

            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("f0");
        }
    }

    public void Finish()
    {
        timerText.color = Color.yellow;
        finished = true;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


}
