using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
    float spawnTime = 0f;
    
    void Start()
    {
        spawnTime = 0f;
    }

    void OnTriggerStay(Collider other)
    {
        if (objectToSpawn != null && spawnTime >= 1)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            spawnTime = 0f;
        }
    }

    void Update()
    {
        spawnTime += Time.deltaTime;
    }

}
