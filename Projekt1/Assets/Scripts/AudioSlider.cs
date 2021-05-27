using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSlider : MonoBehaviour
{
    public AudioMixer audioMixer;

    public static AudioSlider asInstance;

    private void Awake()
    {
        if (asInstance != null && asInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        asInstance = this;
        DontDestroyOnLoad(this);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

}
