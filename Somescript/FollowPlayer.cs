using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 _canvasOffset;
    public float smoothFactor = .5f;

    public Transform target;
    string worldx = "WorldX";
    string worldy = "WorldY";
    string worldz = "WorldZ";
    void Start()
    {
        target.transform.position = new Vector3(PlayerPrefs.GetFloat(worldx), PlayerPrefs.GetFloat(worldy) + 5, PlayerPrefs.GetFloat(worldz));

        _canvasOffset = transform.position - playerTransform.position;
    }

    void Update()
    {
        Vector3 newPos = playerTransform.position + _canvasOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }
}
