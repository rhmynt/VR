using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateExpl : MonoBehaviour
{
    Button mig;
    Explanation explanation;
    void Start()
    {
        mig = GetComponent<Button>();
        mig.onClick.AddListener(CallExplanation);
    }

    public void CallExplanation()
    {
        PlayerPrefs.SetInt("Index", 0);
        explanation = FindObjectOfType<Explanation>();
        int index = PlayerPrefs.GetInt("Index");
        explanation.OpenExplanationCanvas(index);
    }


}
