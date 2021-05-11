using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMageMechanics : MonoBehaviour
{
    public GameObject SkeletonSoul;
    public GameObject SkeletonRevived;

    public int relics = 0;

    private void Update()
    {
        if (relics >= 3)
        {
            SkeletonSoul.SetActive(false);
            SkeletonRevived.SetActive(true);
        }
    }

    public void AddToRelics()
    {
        relics++;
    }

}
