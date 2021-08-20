using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ViewDesc : MonoBehaviour
{
    public ItemDatabase itemList;
    public GameObject d;
    //public Explanation explanationVar;
    int indexMain;

    public void ShowDesc(int index)
    {
        //explanationVar = FindObjectOfType<Explanation>();
        indexMain = PlayerPrefs.GetInt("Index");
        d.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[indexMain].encyAll[index].title;
        d.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[indexMain].encyAll[index].description;
        d.transform.GetChild(2).GetComponent<Image>().sprite = itemList.allItems[indexMain].encyAll[index].illust_0;
        d.transform.GetChild(3).GetComponent<Image>().sprite = itemList.allItems[indexMain].encyAll[index].illust_1;
        d.transform.GetChild(4).GetComponent<Image>().sprite = itemList.allItems[indexMain].encyAll[index].illust_2;
        d.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<FitTheText>().FitView();
    }
}
