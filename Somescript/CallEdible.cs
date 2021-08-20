using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallEdible : MonoBehaviour
{
    Button edibleButton;
    SearchRevise search;
    DestroyPrevSearch destroyPrev;
    void Start()
    {
        edibleButton = GetComponent<Button>();
        edibleButton.onClick.AddListener(CallScript);
    }

    public void CallScript()
    {
        destroyPrev = FindObjectOfType<DestroyPrevSearch>();
        destroyPrev.DestroyPrev();
        search = FindObjectOfType<SearchRevise>();
        search.Edible();
    }

}


