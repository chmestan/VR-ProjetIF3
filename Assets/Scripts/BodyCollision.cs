using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollision : MonoBehaviour
{
    [SerializeField] bool goodPlacementCR = false;
    [SerializeField] bool goodPlacementCL = false;
    [SerializeField] bool goodPlacementH = false;

    void Update()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (gameObject.tag == "controllerR" && other.CompareTag("controllerRTrigger")) goodPlacementCR = true;
        if (gameObject.tag == "controllerL" && other.CompareTag("controllerLTrigger")) goodPlacementCL = true;
        if (gameObject.tag == "head" && other.CompareTag("headTrigger")) goodPlacementH = true;
        
    }


    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("wall")) 
        {
            string s = "";
            switch (gameObject.tag) 
            {
                case "controllerR":
                    s = (goodPlacementCR)? "good CR": "hurt CR";
                    break;
                case "controllerL":
                    s = (goodPlacementCL)? "good CL": "hurt CL";
                    break;
                case "head":
                    s = (goodPlacementH)? "good H": "hurt H";
                    break;
            }
            Debug.Log(s);
        }
    }

}
