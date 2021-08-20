using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultSearchResult : MonoBehaviour
{
    Button clearButton;
    SearchRevise search;
    DestroyPrevSearch destroyPrev;
    void Start()
    {
        clearButton = GetComponent<Button>();
        clearButton.onClick.AddListener(CallScript);
    }

    public void CallScript()
    {
        destroyPrev = FindObjectOfType<DestroyPrevSearch>();
        destroyPrev.DestroyPrev();
        search = FindObjectOfType<SearchRevise>();
        search.DefaultView();
    }
}
