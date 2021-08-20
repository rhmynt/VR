using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignMushroom : MonoBehaviour
{
    float speed = 50f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
