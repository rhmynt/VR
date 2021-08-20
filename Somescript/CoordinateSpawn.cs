using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateSpawn : MonoBehaviour
{
    public Transform target;
    string worldx = "WorldX";
    string worldy = "WorldY";
    string worldz = "WorldZ";
    string id = "ItemID";

    public ItemDatabase itemList;
    public MSpawnerProp mSpawner;
    public CanvasManager mainCanvas;
    void Start()
    {
        Debug.Log("COORDINATE X = " + PlayerPrefs.GetFloat(worldx).ToString());
        Debug.Log("COORDINATE Y = " + PlayerPrefs.GetFloat(worldy).ToString());
        Debug.Log("COORDINATE Z = " + PlayerPrefs.GetFloat(worldz).ToString());
        Debug.Log("Item ID is " + PlayerPrefs.GetString(id));

        /*-------------------------------------SPAWN PLAYER---------------------------------------*/

        target = GameObject.FindWithTag("Player").transform;
        target.transform.position = new Vector3(
            PlayerPrefs.GetFloat(worldx), 
            PlayerPrefs.GetFloat(worldy) + 3, 
            PlayerPrefs.GetFloat(worldz));

        /*-------------------------------------SPAWN MUSHROOM---------------------------------------*/
        /* int index = PlayerPrefs.GetInt("Index");
         GameObject theMushroom = itemList.allItems[index].mushroom3D;
         Debug.Log("Index is " + index);
         Instantiate(theMushroom, transform.position, Quaternion.identity);*/
        mSpawner = FindObjectOfType<MSpawnerProp>();
        mSpawner.MoveInWorld();
       /* -------------------------FOR MOVING THE MAIN CANVAS AND SET IT OFF ------------------------*/
        mainCanvas = FindObjectOfType<CanvasManager>();
        mainCanvas.GetComponent<Canvas>().enabled = false;
        mainCanvas.MainCanvasMoveWorld();



    }
}
