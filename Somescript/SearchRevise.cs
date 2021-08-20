using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SearchRevise : MonoBehaviour
{
    public ItemDatabase itemList;
    public GameObject Search;
    public void Start()
    {
        if (Search == enabled)
        {
            Debug.Log("Search active");
        }
        DefaultView();
    }

    public void DefaultView()
    {
        {
            int listOfItem = itemList.allItems.Count;
            GameObject buttonTemplate = transform.GetChild(0).gameObject;
            GameObject g;
            for (int i = 1; i < listOfItem; i++)
            {
                buttonTemplate.name = i.ToString();

                g = Instantiate(buttonTemplate, transform);

                g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].mushroomName;
                g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].marketName;
                g.transform.GetChild(2).GetComponent<Image>().sprite = itemList.allItems[i].icon;
                int index = i;

                if (itemList.allItems[i].itemTag == "P")
                {
                    g.transform.GetChild(3).GetComponent<Image>().color = new Color32(194, 33, 39, 255);
                    g.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = "POISONOUS";
                }
                else if (itemList.allItems[i].itemTag == "M")
                {
                    g.transform.GetChild(3).GetComponent<Image>().color = new Color32(96, 178, 51, 255);
                    g.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = "MEDICINE";
                }
                else
                {
                    g.transform.GetChild(3).GetComponent<Image>().color = new Color32(19, 186, 191, 255);
                    g.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = "EDIBLE";
                }
                Debug.Log("Index is " + index);
            }

            buttonTemplate.SetActive(false);
            string defaultName = ("Rslt");
            buttonTemplate.name = defaultName;

        }
    }

    public void Medicine()
    {
        {
            int listOfItem = itemList.allItems.Count;
            GameObject buttonTemplate = transform.GetChild(0).gameObject;
            GameObject g;
            for (int i = 1; i < listOfItem; i++)
            {
                if (itemList.allItems[i].itemTag == "M")
                {
                    buttonTemplate.name = i.ToString();

                    g = Instantiate(buttonTemplate, transform);

                    g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].mushroomName;
                    g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].marketName;
                    g.transform.GetChild(2).GetComponent<Image>().sprite = itemList.allItems[i].icon;
                    g.transform.GetChild(3).GetComponent<Image>().color = new Color32(96, 178, 51, 255);
                    g.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = "MEDICINE";
                    int index = i;
                    Debug.Log("Index is " + index);
                }
                
            }

            buttonTemplate.SetActive(false);
            string defaultName = ("Rslt");
            buttonTemplate.name = defaultName;

        }
    }

    public void Edible()
    {
        {
            int listOfItem = itemList.allItems.Count;
            GameObject buttonTemplate = transform.GetChild(0).gameObject;
            GameObject g;
            for (int i = 1; i < listOfItem; i++)
            {
                if (itemList.allItems[i].itemTag == "E")
                {
                    buttonTemplate.name = i.ToString();

                    g = Instantiate(buttonTemplate, transform);

                    g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].mushroomName;
                    g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].marketName;
                    g.transform.GetChild(2).GetComponent<Image>().sprite = itemList.allItems[i].icon;
                    g.transform.GetChild(3).GetComponent<Image>().color = new Color32(19, 186, 191, 255);
                    g.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = "EDIBLE";
                    int index = i;
                    Debug.Log("Index is " + index);
                }

            }

            buttonTemplate.SetActive(false);
            string defaultName = ("Rslt");
            buttonTemplate.name = defaultName;

        }
    }

    public void Poisonous()
    {
        {
            int listOfItem = itemList.allItems.Count;
            GameObject buttonTemplate = transform.GetChild(0).gameObject;
            GameObject g;
            for (int i = 1; i < listOfItem; i++)
            {
                if (itemList.allItems[i].itemTag == "P")
                {
                    buttonTemplate.name = i.ToString();

                    g = Instantiate(buttonTemplate, transform);

                    g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].mushroomName;
                    g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].marketName;
                    g.transform.GetChild(2).GetComponent<Image>().sprite = itemList.allItems[i].icon;
                    g.transform.GetChild(3).GetComponent<Image>().color = new Color32(194, 33, 39, 255);
                    g.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = "POISONOUS";
                    int index = i;
                    Debug.Log("Index is " + index);
                }

            }

            buttonTemplate.SetActive(false);
            string defaultName = ("Rslt");
            buttonTemplate.name = defaultName;

        }
    }
}
