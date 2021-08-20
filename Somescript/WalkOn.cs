using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalkOn : MonoBehaviour
{
    Button on;
    void Start()
    {
        PlayerPrefs.SetInt("Walk", 1);
        on = GetComponent<Button>();
        on.onClick.AddListener(Set1);
    }

    public void Set1()
    {
        PlayerPrefs.SetInt("Walk", 1);
    }
}
