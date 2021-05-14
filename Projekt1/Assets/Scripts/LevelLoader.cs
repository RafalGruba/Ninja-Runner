using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //Scene vars
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options Menu");
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");

    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");

    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");

    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");

    }
    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level 5");

    }

}
