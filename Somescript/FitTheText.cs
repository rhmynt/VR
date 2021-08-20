using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FitTheText : MonoBehaviour
{
    public void FitView()
    {
        int totalChar = GetComponentInChildren<TextMeshProUGUI>().text.Length;
        Debug.Log("TOTAL CHAR " + totalChar);
        RectTransform rt = this.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(0f, totalChar/54f*48.5f);
    }
}
