using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float myTimeScale = 0.1f;
    [SerializeField] float timePassing = 0.1f;

    //cached objects
    public GameObject endLevelUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LevelComplete());
    }


    IEnumerator LevelComplete()
    {
        FindObjectOfType<GameSession>().Finish();
        Time.timeScale = myTimeScale;
        yield return new WaitForSeconds(timePassing);
        Time.timeScale = 0f;
        endLevelUI.SetActive(true);
    }
}
