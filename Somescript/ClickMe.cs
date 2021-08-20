using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//THIS IS - OPEN EPLANATION BUTTON
public class ClickMe : MonoBehaviour
{
    Transform player;
    Transform mainCanvas;

    Button clickme;

    public Material skymat;
    Vector3 moveToAir = new Vector3(239f, 120f, 140f);

    public GameObject canvasWorld;
    void Start()
    {
        clickme = GetComponent<Button>();
        clickme.onClick.AddListener(MovePlayerOffWalk);
        clickme.onClick.AddListener(MoveMainCanvas);
        clickme.onClick.AddListener(ChangeSkyDome);
        clickme.onClick.AddListener(OffSelf);
    }

    public void MovePlayerOffWalk()
    {
        player = GameObject.FindWithTag("Player").transform;
        player.transform.position = moveToAir;
        player.GetComponent<VRLookWalk>().enabled = false;
        player.GetComponent<CharacterController>().enabled = true;
        player.GetComponent<PlayerWalk>().enabled = false;
        if(canvasWorld.transform.GetChild(4).gameObject.activeSelf == true)
        {
            PlayerPrefs.SetString("Button", "OnOff");
            canvasWorld.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (canvasWorld.transform.GetChild(5).gameObject.activeSelf == true)
        {
            PlayerPrefs.SetString("Button", "VR");
            canvasWorld.transform.GetChild(5).gameObject.SetActive(false);
        }
    }

    public void MoveMainCanvas()
    {
        mainCanvas = GameObject.FindWithTag("MainCanvas").transform;
        mainCanvas.transform.position = new Vector3(239f, 120f, 145f);
    }
    public void ChangeSkyDome()
    {
        RenderSettings.skybox = skymat;
    }

    public void OffSelf()
    {
        gameObject.SetActive(false);
    }

}
