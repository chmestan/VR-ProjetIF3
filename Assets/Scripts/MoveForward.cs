using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{
    [SerializeField] Vector3 localisation;
    [SerializeField] Vector3 rotating;
    [SerializeField] float speed = 1f;
    void OnEnable()
    {
        transform.position = localisation;
        transform.rotation = Quaternion.Euler(rotating.x, rotating.y, rotating.z);
    }
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}