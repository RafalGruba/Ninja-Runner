using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip tpUsed;
    public AudioClip pickedUpSomething;
    public AudioClip platformIsAboutToFall;

    public static SfxManager sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxInstance = this;
        DontDestroyOnLoad(this);
    }


}
