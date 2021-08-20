using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallPoisonous : MonoBehaviour
{
    Button poisonButton;
    SearchRevise search;
    DestroyPrevSearch destroyPrev;
    void Start()
    {
        poisonButton = GetComponent<Button>();
        poisonButton.onClick.AddListener(CallScript);
    }

    public void CallScript()
    {
        destroyPrev = FindObjectOfType<DestroyPrevSearch>();
        destroyPrev.DestroyPrev();
        search = FindObjectOfType<SearchRevise>();
        search.Poisonous();
    }
}
