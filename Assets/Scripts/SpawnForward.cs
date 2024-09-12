using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnForward : MonoBehaviour
{
    [SerializeField] Vector3 localisation;
    [SerializeField] Vector3 rotating;
    [SerializeField] float speed = 1f;
    public GameObject objectToSpawn;
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
    void OnEnable()
    {
        transform.position = localisation;
        transform.rotation = Quaternion.Euler(rotating.x, rotating.y, rotating.z);
    }
    void Update()
    {
        spawnTime += Time.deltaTime;
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}