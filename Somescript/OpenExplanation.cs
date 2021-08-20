using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//SCRIPT INI DIPAKE DI CANVAS (PARENT) CLICK ME
public class OpenExplanation : MonoBehaviour
{
    Button clickMe;
    Explanation explanation;
    GameObject mainCanvas;

    void Start()
    {
        clickMe = GetComponent<Button>();
        clickMe.onClick.AddListener(OpenExpl);
        mainCanvas = GameObject.FindWithTag("MainCanvas");
    
    }

    public void OpenExpl()
    {
        Debug.Log("Click Me button is clicked");
        CanvasManager.GetInstance().SwitchCanvas(CanvasType.Explanations);
        explanation = FindObjectOfType<Explanation>();
        int index = PlayerPrefs.GetInt("Index");
        explanation.OpenExplanationCanvas(index);
        mainCanvas.GetComponent<Canvas>().enabled = true;

    }
}
