using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSpawnerProp : MonoBehaviour
{
    public GameObject canvasBillboard;
    //public GameObject mSpawner;
    private static MSpawnerProp instance;

    //---------------------------------------------------- 
    //For second scene (World)
    public Transform target;
    string worldx = "WorldX";
    string worldy = "WorldY";
    string worldz = "WorldZ";

    public ItemDatabase itemList;

    /*    GameObject theMushroom;
        GameObject InstantiatedObj;*/

    public MushroomSpawner mSpawner;
    public MushroomAudio mAudio;

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
    private void Start()
    {
        canvasBillboard.GetComponent<Canvas>().enabled = false;
    }

    public void MoveInWorld()
    {
        target = GameObject.FindWithTag("Respawn").transform;
        target.transform.position = new Vector3(
            PlayerPrefs.GetFloat(worldx),
            PlayerPrefs.GetFloat(worldy),
            PlayerPrefs.GetFloat(worldz));
        /*        //This for spawn---------
                int index = PlayerPrefs.GetInt("Index");
                theMushroom = itemList.allItems[index].mushroom3D;

                Vector3 rot = itemList.allItems[index].rotation;

                InstantiatedObj = (GameObject)Instantiate(theMushroom, transform.position, 
                    transform.rotation*Quaternion.Euler(rot.x, rot.y, rot.z));*/

        mSpawner = GetComponent<MushroomSpawner>();
        mSpawner.CallScriptWorld();

        mAudio = GetComponent<MushroomAudio>();
        mAudio.AddAudio();
    }
}
