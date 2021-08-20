using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 315f;
    public float playerSpeed = 2f;
    public bool moveForward;

    void Start()
    {

    }

    void Update()
    {
        playerSpeed = PlayerPrefs.GetFloat("PlayerSpeed");
        /*        if (Input.GetButton("Fire1"))
                {
                    transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
                }*/
        int walkToogle = PlayerPrefs.GetInt("Walk");

        Debug.Log(vrCamera.eulerAngles.x);

        if (vrCamera.eulerAngles.x <= toggleAngle && vrCamera.eulerAngles.x > 270)
        {
            moveForward = false;
        }
        else
        {
            moveForward = true;
        }

        if (walkToogle == 1 && moveForward == true)
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;

        }
        else if (walkToogle == 0)
        {
            Debug.Log("Player stop");
        }
    }
}
