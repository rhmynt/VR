using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed2 : MonoBehaviour
{
    Button speed2;
    void Start()
    {
        speed2 = GetComponent<Button>();
        speed2.onClick.AddListener(SetSpeed);
    }
     public void SetSpeed()
    {
        PlayerPrefs.SetFloat("PlayerSpeed", 2f);
    }
}
