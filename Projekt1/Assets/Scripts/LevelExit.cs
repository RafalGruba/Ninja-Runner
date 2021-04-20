using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float myTimeScale = 0.1f;
    [SerializeField] float timePassing = 0.1f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LevelComplete());
    }


    IEnumerator LevelComplete()
    {
        FindObjectOfType<GameSession>().Finish();
        Time.timeScale = myTimeScale;
        Debug.Log("slow-mo is set");
        yield return new WaitForSeconds(timePassing);
        Time.timeScale = 0f;
        Debug.Log("Level has been complete. This Debug will be changed to Load UI where you can see your score, go to main menu, next level or restart level, etc.");
    }
}
