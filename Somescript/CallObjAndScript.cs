using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallObjAndScript : MonoBehaviour
{
    Button caInfo;
    public ItemDatabase itemList;
    GameObject theMushroom;
    void Start()
    {
        caInfo = GetComponent<Button>();
        caInfo.onClick.AddListener(CallScript);
        theMushroom = itemList.allItems[1].mushroom3D;
    }

    public void CallScript()
    {
        Instantiate(theMushroom, 
            transform.position = new Vector3(7,2,2), 
            Quaternion.identity);
    }

}
