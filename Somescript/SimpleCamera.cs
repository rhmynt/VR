using UnityEngine;
using UnityEngine.UI;

// here is my device camera script

public class SimpleCamera : MonoBehaviour
{
    static WebCamTexture backCam;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        if (backCam == null)
        {
            backCam = new WebCamTexture();
        }
        GetComponent<RawImage>().texture = backCam;
        backCam.Play();
    }
}