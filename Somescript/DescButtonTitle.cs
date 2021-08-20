using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DescButtonTitle : MonoBehaviour
{
    Button titleButton;
    int descIndex;
    ViewDesc ViewTheDesc;

    private void OnEnable()
    {
        titleButton = GetComponent<Button>();
        titleButton.onClick.AddListener(ViewIndex);
    }

    public void ViewIndex()
    {
        descIndex = transform.GetSiblingIndex();
        Debug.Log("View Index button clicked " + descIndex);
        ViewTheDesc = FindObjectOfType<ViewDesc>();
        ViewTheDesc.ShowDesc(descIndex - 1);
        
    }
}
