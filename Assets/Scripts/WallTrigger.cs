using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    // apply on Player
    List<GameObject> wallList = new List<GameObject>();
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    private int wallIndex;

    void Start()
    {
        wallIndex = UnityEngine.Random.Range(0,3);
        wallList.Add(wall1);
        wallList.Add(wall2);
        wallList.Add(wall3);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnTrigger")) Instantiate(wallList[wallIndex]);
 
    }
}
