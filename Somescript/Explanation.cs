using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.UI;
public class Explanation : MonoBehaviour
{
    public ItemDatabase itemList;
    //public int index;
    public void OpenExplanationCanvas(int index)
    {
            int listOfDesc = itemList.allItems[index].encyAll.Length;
            GameObject buttonTemplate = transform.GetChild(1).GetChild(1).GetChild(0).gameObject;
            GameObject g;
            for (int i = 0; i < listOfDesc; i++)
            {
                g = Instantiate(buttonTemplate, transform.GetChild(1).GetChild(1));
                g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[index].encyAll[i].title;
                g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.UpperCase;
            }
        buttonTemplate.SetActive(false);
        return;
    }


}
