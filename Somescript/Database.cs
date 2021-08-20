using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Database : MonoBehaviour
{
    public ItemDatabase items;
    private static Database instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static EncyData GetItemByID(string ID)
    {
        
        //This below is a way to check the ID with Linq-----------------------------
        return instance.items.allItems.FirstOrDefault(i => i.itemID == ID);
        
        /*
        This below is another way to check the ID without using Linq ------------      
        foreach(EncyData item in instance.items.allItems)
        {
            if(item.itemID == ID)
            {
                return item;
            }
        }*/
        return null;
   
    }

    public static EncyData GetItemByTag(string Tag)
    {
        return instance.items.allItems.FirstOrDefault(i => i.itemTag == Tag);
    }

}
