using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardUI : MonoBehaviour
{
    //public Camera activeCamera;

    public void Update()
    {
        Camera camera = (Camera)FindObjectOfType(typeof(Camera));
        //transform.LookAt(transform.position + activeCamera.transform.rotation * Vector3.forward, activeCamera.transform.rotation * Vector3.up);

        transform.LookAt(transform.position + camera.transform.rotation * Vector3.forward, camera.transform.rotation * Vector3.up);

    }
}
