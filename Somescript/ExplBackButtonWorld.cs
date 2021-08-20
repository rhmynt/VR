using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplBackButtonWorld : MonoBehaviour
{
    Button backButtonWorld;
    DestroyExplButton DestroyButton;
    Transform player;
    Transform mainCanvas;
    public Material skymatDefault;

    string worldx = "WorldX";
    string worldy = "WorldY";
    string worldz = "WorldZ";

    GameObject canvasWorld;

    public void Start()
    {
        backButtonWorld = GetComponent<Button>();
        backButtonWorld.onClick.AddListener(BackToMushroom);
        backButtonWorld.onClick.AddListener(EnableOpenExplButton);
    }

    public void BackToMushroom()
    {
        //Destroy button
        DestroyButton = FindObjectOfType<DestroyExplButton>();
        DestroyButton.GetChildAndDestroy();

        //Move player back to mushroom coordinate and activate walk
        player = GameObject.FindWithTag("Player").transform;
        player.transform.position = new Vector3(
            PlayerPrefs.GetFloat(worldx),
            PlayerPrefs.GetFloat(worldy) + 3,
            PlayerPrefs.GetFloat(worldz));

        //Move canvas and shut it off
        mainCanvas = GameObject.FindWithTag("MainCanvas").transform;
        mainCanvas.transform.position = new Vector3(
            PlayerPrefs.GetFloat(worldx),
            PlayerPrefs.GetFloat(worldy) + 3,
            PlayerPrefs.GetFloat(worldz));
        mainCanvas.GetComponent<Canvas>().enabled = false;

        RenderSettings.skybox = skymatDefault;

        //ENABLE WALK BUTTON
        canvasWorld = GameObject.FindWithTag("CanvasWorld").gameObject;
        if (PlayerPrefs.GetString("Button") == "OnOff")
        {
            canvasWorld.transform.GetChild(4).gameObject.SetActive(true);
            player.GetComponent<VRLookWalk>().enabled = true;
            player.GetComponent<PlayerWalk>().enabled = false;
        }
        else if (PlayerPrefs.GetString("Button") == "VR")
        {
            canvasWorld.transform.GetChild(5).gameObject.SetActive(true);
            player.GetComponent<PlayerWalk>().enabled = true;
            player.GetComponent<CharacterController>().enabled = false;
        }

    }

    public void EnableOpenExplButton()
    {
        canvasWorld = GameObject.FindWithTag("CanvasWorld").gameObject;
        canvasWorld.transform.GetChild(3).gameObject.SetActive(true);
    }
}
