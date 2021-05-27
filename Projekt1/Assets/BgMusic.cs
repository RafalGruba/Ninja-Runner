using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgMusic : MonoBehaviour
{
    Scene scene;
    public AudioSource audioSource;
    public AudioClip mainMenuTheme;
    public AudioClip forestTheme;
    public AudioClip desertTheme;
    public AudioClip cemeteryTheme;

    public static BgMusic bgInstance;

    private void Awake()
    {
        if (bgInstance != null && bgInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        bgInstance = this;       
        DontDestroyOnLoad(this);
    }



}
