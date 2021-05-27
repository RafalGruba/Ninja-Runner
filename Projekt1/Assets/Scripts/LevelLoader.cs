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
        Time.timeScale = 1f;
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

    public void LoadMainMenuFromLevels()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        BgMusic.bgInstance.audioSource.Stop();
        BgMusic.bgInstance.audioSource.loop = true;
        BgMusic.bgInstance.audioSource.clip = BgMusic.bgInstance.mainMenuTheme;
        BgMusic.bgInstance.audioSource.volume = 1f;
        BgMusic.bgInstance.audioSource.Play();
    }

    public void LoadTutorialLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tutorial");
    }
    public void LoadLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
        BgMusic.bgInstance.audioSource.Stop();
        BgMusic.bgInstance.audioSource.loop = true;
        BgMusic.bgInstance.audioSource.clip = BgMusic.bgInstance.forestTheme;
        BgMusic.bgInstance.audioSource.volume = 1f;
        BgMusic.bgInstance.audioSource.Play();
    }

    public void LoadLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 2");
        BgMusic.bgInstance.audioSource.Stop();
        BgMusic.bgInstance.audioSource.loop = true;
        BgMusic.bgInstance.audioSource.clip = BgMusic.bgInstance.desertTheme;
        BgMusic.bgInstance.audioSource.volume = 1f;
        BgMusic.bgInstance.audioSource.Play();
    }
    public void LoadLevel3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 3");
        BgMusic.bgInstance.audioSource.Stop();
        BgMusic.bgInstance.audioSource.loop = true;
        BgMusic.bgInstance.audioSource.clip = BgMusic.bgInstance.cemeteryTheme;
        BgMusic.bgInstance.audioSource.volume = 1f;
        BgMusic.bgInstance.audioSource.Play();
    }
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits Scene");
    }
    public void LoadCreditsSceneFromLevels()
    {
        SceneManager.LoadScene("Credits Scene");
        BgMusic.bgInstance.audioSource.Stop();
        BgMusic.bgInstance.audioSource.loop = true;
        BgMusic.bgInstance.audioSource.clip = BgMusic.bgInstance.mainMenuTheme;
        BgMusic.bgInstance.audioSource.volume = 1f;
        BgMusic.bgInstance.audioSource.Play();
    }
    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
