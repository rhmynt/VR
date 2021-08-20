using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalkOff : MonoBehaviour
{
    Button off;
    void Start()
    {
        off = GetComponent<Button>();
        off.onClick.AddListener(Set0);
    }

    public void Set0()
    {
        PlayerPrefs.SetInt("Walk", 0);
    }

}
