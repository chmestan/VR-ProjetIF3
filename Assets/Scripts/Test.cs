using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Vector3 localisation ;  
    [SerializeField] float speed = 1f; 
    void OnEnable()
    {
        transform.position = localisation;
    }
    void Update()
    {
        transform.Translate(Vector3.up  * speed * Time.deltaTime);
    }


}
