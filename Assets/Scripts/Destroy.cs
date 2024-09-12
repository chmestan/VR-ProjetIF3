using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] float destroyTime = 7f;

    void Update()
    {
        if (gameObject != null && destroyTime >= 7)
        {
            Destroy(gameObject,destroyTime);
            destroyTime = 0f;
        }
    }
}
