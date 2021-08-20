using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public static class ButtonExtension
{
    public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
       {
           OnClick(param);
       });
    }
}

public class SearchCanvas : MonoBehaviour
{
    public GameObject searchCanvasIsActive;

    public ItemDatabase itemList;

    public void Start()
    {
        if (searchCanvasIsActive == enabled)
        {
            Debug.Log("Search Canvas is Active!");

            /*--------------------------------INSTANTIATE BUTTON------------------------------------*/

            int listOfItem = itemList.allItems.Count;

            GameObject buttonTemplate = transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0).GetChild(0).gameObject;
            GameObject g;
            for (int i = 0; i < listOfItem; i++)
            {
                g = Instantiate(buttonTemplate, transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0));
                g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].mushroomName ;
                g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].itemID ;

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

                g.GetComponent<Button>().AddEventListener(i, ItemClicked);

            }

            //Destroy(buttonTemplate);
            buttonTemplate.SetActive(false);

        }

        /*-------------------------------------------------------------------------------------------------------------*/

        void ItemClicked(int itemIndex)
        {
            Debug.Log("item " + itemIndex + " clicked");
            Vector3 pos = itemList.allItems[itemIndex].position;
            string id = itemList.allItems[itemIndex].itemID;
            PlayerPrefs.SetInt("Index", itemIndex);
            PlayerPrefs.SetFloat("WorldX", pos.x);
            PlayerPrefs.SetFloat("WorldY", pos.y);
            PlayerPrefs.SetFloat("WorldZ", pos.z);
            PlayerPrefs.SetString("ItemID", id);
            JumpScene(1);
        }
    }

    public void PoisonClicked()
    {
        int listOfItem = itemList.allItems.Count;
        GameObject buttonTemplate = transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0).GetChild(0).gameObject;
        GameObject g;

        Debug.Log("Class is read");

        for (int i = 0; i < listOfItem; i++)
        {
            Debug.Log("For is read");
            if (itemList.allItems[i].itemTag == "P")
            {
                Debug.Log("If is read");
                g = Instantiate(buttonTemplate, transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0));
                g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].mushroomName;
                g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = itemList.allItems[i].itemID;
                g.transform.GetChild(3).GetComponent<Image>().color = new Color32(194, 33, 39, 255);
                g.transform.GetChild(3).GetChild(0).GetComponent<TextMeshProUGUI>().text = "POISONOUS";
            }
            else
            {
                Debug.Log("Else is read");
                return;
            }

        }

    }

    public GameObject loadingScreen;
    public Slider slider;

    public void JumpScene(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        loadingScreen.SetActive(true);

    while(!operation.isDone)
    {
        float progress = Mathf.Clamp01(operation.progress / 0.9f);
        slider.value = progress;

        yield return null;
    }
        loadingScreen.SetActive(false);

    }
    
}
