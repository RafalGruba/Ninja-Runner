using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject woodenCrate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(woodenCrate);
        Destroy(gameObject);
    }


}
