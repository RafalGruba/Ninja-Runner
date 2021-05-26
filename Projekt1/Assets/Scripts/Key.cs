using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject woodenCrate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SfxManager.sfxInstance.audioSource.PlayOneShot(SfxManager.sfxInstance.pickedUpSomething);
        Destroy(woodenCrate);
        Destroy(gameObject);
    }


}
