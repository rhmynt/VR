using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWall : MonoBehaviour
{
    bool hit = false;
    GameObject canvasWorld;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Debug.LogWarning("Hit the wall");
            hit = true;
        }
        else
        {
            hit = false;
        }
    }
    private void Start()
    {
        canvasWorld = GameObject.FindWithTag("CanvasWorld");

    }

    private void Update()
    {
        if (hit == true)
        {
            canvasWorld.transform.GetChild(6).gameObject.SetActive(true);
            canvasWorld.transform.GetChild(6).Rotate(Vector3.forward * 50f * Time.deltaTime);
            Debug.LogWarning("It should works on canvas too");
        }
        else
        {
            canvasWorld.transform.GetChild(6).gameObject.SetActive(false);
        }
    }
    /*    GameObject canvasWorld;
        bool hit =  false;

        void Start()
        {
            canvasWorld = GameObject.FindWithTag("CanvasWorld");
            Debug.LogWarning("Script read");
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.name == "Player")
            {
                hit = true;
                Debug.LogWarning("Could read the collision");
            }
        }
        void Update()
        {
            if (hit == true)
            {
                canvasWorld.transform.GetChild(6).gameObject.SetActive(true);
                canvasWorld.transform.Rotate(Vector3.up * 50f * Time.deltaTime);
                Debug.LogWarning("It should works on canvas too");
            }
        }*/


}
