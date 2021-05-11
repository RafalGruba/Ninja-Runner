using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanism : MonoBehaviour
{
    public GameObject verticalCrate1;
    public GameObject verticalCrate2;
    public GameObject horizontalCrate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        verticalCrate1.SetActive(false);
        verticalCrate2.SetActive(false);
        horizontalCrate.SetActive(true);
    }


}
