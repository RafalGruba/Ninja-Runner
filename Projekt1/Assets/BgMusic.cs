using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic : MonoBehaviour
{
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
