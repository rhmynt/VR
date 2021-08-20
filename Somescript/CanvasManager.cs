using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum CanvasType
{
    MainMenu,
    Explanations,
    SearchUI,
    CreditInfo,
    HowToUse
}

public class CanvasManager : Singleton<CanvasManager>
{
    List<CanvasController> canvasControllerList;
    CanvasController lastActiveCanvas;
    GameObject button;
    GameObject buttonWorld;
    //For second scene (world)
    public Transform target;
    string worldx = "WorldX";
    string worldy = "WorldY";
    string worldz = "WorldZ";

    public ItemDatabase itemList;
    protected override void Awake()
    {
        base.Awake();
        canvasControllerList = GetComponentsInChildren<CanvasController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false));
        SwitchCanvas(CanvasType.MainMenu);
        button = gameObject.transform.GetChild(1).GetChild(3).gameObject;
        buttonWorld = gameObject.transform.GetChild(1).GetChild(4).gameObject;
    }

    private void Start()
    {
        buttonWorld.SetActive(false);
    }
    public void SwitchCanvas(CanvasType _type)
    {
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }

        CanvasController desiredCanvas = canvasControllerList.Find(x => x.canvasType == _type);
        if (desiredCanvas != null)
        {
            desiredCanvas.gameObject.SetActive(true);
            lastActiveCanvas = desiredCanvas;
        }
        else { Debug.LogWarning("The desired canvas was not found!"); }
    }

    public void MainCanvasMoveWorld()
    {
        target = GameObject.FindWithTag("MainCanvas").transform;
        target.transform.position = new Vector3(
            PlayerPrefs.GetFloat(worldx),
            PlayerPrefs.GetFloat(worldy) + 5,
            PlayerPrefs.GetFloat(worldz));
    }

    public void ToogleExplButton()
    {
        Debug.Log("Toogle button-desu! > "+button.name);
        Debug.Log("Toolge button world-desu! > "+buttonWorld.name);
        if (button.activeSelf == true)
        {
            button.SetActive(false);
            buttonWorld.SetActive(true);
            Debug.Log("IF nya kebaca");
        }
        else if (buttonWorld.activeSelf == true)
        {
            button.SetActive(true);
            buttonWorld.SetActive(false);
            Debug.Log("IF ke-2 kebaca");
        }
    }
}












