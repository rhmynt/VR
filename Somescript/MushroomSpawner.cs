using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class only works on 1st Scene (Menu Scene) 
public class MushroomSpawner : MonoBehaviour
{
    public ItemDatabase itemList;
    GameObject theMushroom;
    GameObject InstantiatedObj;
    /*    int indexMushroom;
        public Explanation expl;*/
    int index;

    //KEKNYA YANG CALLSCRIPT() GAK KEPAKE DAH. MAKENYA YANG CALLSCRIPTWORLD()
    public void CallScript()
    {
/*        expl = FindObjectOfType<Explanation>();
        indexMushroom = expl.index;*/
        index = PlayerPrefs.GetInt("Index");
        theMushroom = itemList.allItems[index].mushroom3D;
        InstantiatedObj = (GameObject)Instantiate(theMushroom, transform.position, Quaternion.identity);
    }

    public void CallScriptWorld()
    {
        index =  PlayerPrefs.GetInt("Index");
        theMushroom = itemList.allItems[index].mushroom3D;
        
        Vector3 rot = itemList.allItems[index].rotation;

        InstantiatedObj = (GameObject)Instantiate(theMushroom, transform.position,
            transform.rotation * Quaternion.Euler(rot.x, rot.y, rot.z));
    }
    public void DestroyOnExit()
    {
        Destroy(InstantiatedObj);
    }
}
