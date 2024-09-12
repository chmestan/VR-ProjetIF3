using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject destroyObject;
    float destroyTime = 7f;

    void Update()
    {
        if (destroyObject != null && destroyTime >= 7)
        {
            Destroy(destroyObject,destroyTime);
            destroyTime = 0f;
        }
    }
}
