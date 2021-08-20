using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyMushroom : MonoBehaviour
{
    Button backButton;
    MushroomSpawner Spawn;
    DestroyExplButton DestroyButton;
    MushroomAudio DestroyAudio;
    //public GameObject canvasBillboard;

    public void Start()
    {
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(CallDestroy);
    }

    public void CallDestroy()
    {
        //Destroy button
        DestroyButton = FindObjectOfType<DestroyExplButton>();
        DestroyButton.GetChildAndDestroy();
        //Destroy spawned mushroom
        Spawn = FindObjectOfType<MushroomSpawner>();
        Spawn.DestroyOnExit();
        //Destroy audio
        DestroyAudio = FindObjectOfType<MushroomAudio>();
        DestroyAudio.DestroyOnExit();

        //canvasBillboard.GetComponent<Canvas>().enabled = false;
    }
}
