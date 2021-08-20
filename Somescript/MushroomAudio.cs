using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MushroomAudio : MonoBehaviour
{
    public ItemDatabase itemList;
    //public AudioClip audioPlay;
    /*int audioIndex;
    public Explanation expl;*/
    int index;

    public void AddAudio()
    {
        /*expl = FindObjectOfType<Explanation>();
        audioIndex = expl.index;*/
        //--------------------------------------------------------------------------
        //--------------------------------------------------------------------------
        index = PlayerPrefs.GetInt("Index");
        itemList.allItems[index].source = gameObject.AddComponent<AudioSource>();
        itemList.allItems[index].source.clip = itemList.allItems[index].clip;
        itemList.allItems[index].source.Play();
        Debug.Log("Seems fine");
    }

    public void DestroyOnExit()
    {
        index = PlayerPrefs.GetInt("Index");

        Destroy(itemList.allItems[index].source);
        
        Debug.Log("This mean the code read the destroy audio component");
    }
}
