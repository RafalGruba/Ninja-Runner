using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour
{
    // Time vars
    public TMP_Text timerText;
    public TMP_Text timerTextEndLevel;
    private float startTime;
    public int countdownTime = 3;
    public TMP_Text countdownDisplay;
    private bool finished = false;
    private bool cdFinished = false;



    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public void Timer()
    {
        if (cdFinished)
        {
            if (finished == false)
            {
                float t = Time.time - startTime;
                string minutes = ((int)t / 60).ToString();
                string seconds = (t % 60).ToString("f2");
                timerText.text = minutes + ":" + seconds;
            }

        }
    }

    public void Finish()
    {
        finished = true;
        timerTextEndLevel.color = Color.yellow;
        timerTextEndLevel.text = timerText.text;
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownDisplay.text = "GO!";
        yield return new WaitForSeconds(1f);
        cdFinished = true;
        startTime = Time.time;
        FindObjectOfType<Player>().CdFinished(); 
        countdownDisplay.gameObject.SetActive(false);
    }

}
