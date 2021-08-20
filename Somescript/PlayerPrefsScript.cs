using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsScript : MonoBehaviour
{
    string worldx = "WorldX";
    string worldy = "WorldY";
    string worldz = "WorldZ";

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        int buildIndex = currentScene.buildIndex;

        if (sceneName == "World" && buildIndex == 1)
        {
            Debug.Log("COORDINATE X = " + PlayerPrefs.GetFloat(worldx).ToString());
            Debug.Log("COORDINATE Y = " + PlayerPrefs.GetFloat(worldy).ToString());
            Debug.Log("COORDINATE Z = " + PlayerPrefs.GetFloat(worldz).ToString());
        }
        else
        {
            Debug.LogWarning("This is not the desired scene");
        }
    }
}
