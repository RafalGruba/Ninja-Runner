using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;
    private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
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
            float minutes = (int)(Time.timeSinceLevelLoad / 60f);
            float seconds = (int)(Time.timeSinceLevelLoad % 60f);
            float milliseconds = (int)(Time.timeSinceLevelLoad * 6f);

            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }
    }

    public void Finish()
    {
        timerText.color = Color.yellow;
        finished = true;
    }


}
