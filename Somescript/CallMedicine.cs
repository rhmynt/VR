using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallMedicine : MonoBehaviour
{
    Button medButton;
    SearchRevise search;
    DestroyPrevSearch destroyPrev;
    void Start()
    {
        medButton = GetComponent<Button>();
        medButton.onClick.AddListener(CallScript);
    }

    public void CallScript()
    {
        destroyPrev = FindObjectOfType<DestroyPrevSearch>();
        destroyPrev.DestroyPrev();
        search = FindObjectOfType<SearchRevise>();
        search.Medicine();
    }
}
