using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportOut;
    public GameObject player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        SfxManager.sfxInstance.audioSource.PlayOneShot(SfxManager.sfxInstance.tpUsed);
        player.transform.position = teleportOut.transform.position;
    }
}
