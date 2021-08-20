using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowTo : MonoBehaviour
{
    Button howToUse;
    public ItemDatabase itemList;
    MushroomSpawner Spawn;
    MushroomAudio AudioSpawn;

    public GameObject mainCanvas;
    public GameObject canvasBillboard;
    void Start()
    {
        howToUse = GetComponent<Button>();
        howToUse.onClick.AddListener(SpawnMushroom);
    }

    public void SpawnMushroom()
    {
        if (mainCanvas == enabled)
        {
            mainCanvas.GetComponent<Canvas>().enabled = false;
            canvasBillboard.GetComponent<Canvas>().enabled = true;
        }


        Spawn = FindObjectOfType<MushroomSpawner>();
        Spawn.CallScriptWorld();

        AudioSpawn = FindObjectOfType<MushroomAudio>();
        AudioSpawn.AddAudio();
    }
}
