using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollision : MonoBehaviour
{
    public bool goodPlacementCR = false;
    public bool goodPlacementCL = false;
    public bool goodPlacementH = false;

    [SerializeField] GameObject player;
    PlayerHit hit;

    void Update()
    {
        hit = player.GetComponent<PlayerHit>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wall")) 
        {
        goodPlacementCR = false;
        goodPlacementCL = false;
        goodPlacementH = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (gameObject.CompareTag("controllerR") && other.CompareTag("controllerRTrigger")) goodPlacementCR = true;
        if (gameObject.CompareTag("controllerL") && other.CompareTag("controllerLTrigger")) goodPlacementCL = true;
        if (gameObject.CompareTag("head") && other.CompareTag("headTrigger")) goodPlacementH = true; 
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("wall")) 
        {
            hit.CheckDamage();
        }
    }

}
