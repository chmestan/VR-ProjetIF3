using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    // apply on Player
    // List<GameObject> wallList = new List<GameObject>();
    public GameObject wall1;
    // public GameObject wall2;
    // public GameObject wall3;
    // private int wallIndex;

    void Start()
    {
        // wallIndex = UnityEngine.Random.Range(0,3);
        // wallList.Add(wall1);
        // wallList.Add(wall2);
        // wallList.Add(wall3);
    }
    void OnTriggerExit(Collider other)
    {
        // if (other.CompareTag("SpawnTrigger")) Instantiate(wallList[wallIndex],new Vector3(0,0,50),Quaternion.identity);
        if (other.CompareTag("SpawnTrigger")) Instantiate(wall1,new Vector3(0,0,200),Quaternion.identity);
        // Debug.Log(wallList[wallIndex]);
    }

    
}
