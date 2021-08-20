using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrevSearch : MonoBehaviour
{
    public GameObject prevSearch;
    public GameObject template;

    public void DestroyPrev()
    {
        Transform[] allChildren = this.transform.GetComponentsInChildren<Transform>();
        int length = allChildren.Length;

        Debug.Log("The total of childs are " + length);

        for (int i = 1; i < length/4.5 ; i++)
        {
            Debug.Log("The buttons are " + allChildren[i].name);
            prevSearch = transform.GetChild(i).gameObject;
            Destroy(prevSearch);
        }
        template.SetActive(true);
    }
}
