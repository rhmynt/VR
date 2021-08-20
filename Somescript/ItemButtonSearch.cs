using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemButtonSearch : MonoBehaviour
{
    Button buttonResult;
    public ItemDatabase item;
    public CanvasManager mainCanvas;
    //public Explanation explanation;
    public Transform mainCanvasT;

    void Start()
    {
        buttonResult = GetComponent<Button>();
        buttonResult.onClick.AddListener(ResultClicked);
    }

    public void ResultClicked()
    {
        //THIS IS FOR OBTAIN THE INDEX OF MUSHROOM
        string name = buttonResult.name;
        char[] charsToTrim = { ')', 'e', 'n', 'o', 'l', 'C', '(' };
        string cleanName = name.TrimEnd(charsToTrim);
        Debug.Log(cleanName);
        int indexDB = int.Parse(cleanName);
        string test = item.allItems[indexDB].mushroomName;
        Debug.Log(test);
        //THIS FOR SET THE COORDINATE FOR THE WORLD AND INDEX OF DATABASE
        Vector3 pos = item.allItems[indexDB].position;
        string id = item.allItems[indexDB].itemID;
        PlayerPrefs.SetInt("Index", indexDB);
        PlayerPrefs.SetFloat("WorldX", pos.x);
        PlayerPrefs.SetFloat("WorldY", pos.y);
        PlayerPrefs.SetFloat("WorldZ", pos.z);
        PlayerPrefs.SetString("ItemID", id);

        //OFF MAIN CANVAS
        //mainCanvasT.transform.position = new Vector3(5.53f, -4f, 11.03f);
        mainCanvasT.transform.GetChild(2).position = new Vector3(5.53f, -4f, 11.03f);

        JumpScene(1);

        //Activate the other expl button
        mainCanvas = FindObjectOfType<CanvasManager>();
        mainCanvas.ToogleExplButton();
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

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;

            yield return null;
        }
        loadingScreen.SetActive(false);

    }

}
