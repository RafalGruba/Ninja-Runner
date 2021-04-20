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
            float timePassedSinceStart = Time.time - startTime;
            string minutes = ((int)timePassedSinceStart / 60).ToString();
            string seconds = (timePassedSinceStart % 60).ToString("f2");
            timerText.text = minutes + "," + seconds;
        }
    }

    public void Finish()
    {
        timerText.color = Color.yellow;
        finished = true;
    }


}
