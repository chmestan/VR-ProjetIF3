using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRCollision : MonoBehaviour
{

    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ControllerR"))
        {
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("wall")) 
        {
            
        }
    }

}
