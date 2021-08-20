using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

//THIS IS FOR BACK BUTTON FROM WORLD TO MAIN MENU
public class ButtonManagement : MonoBehaviour
{
    Button backButton;
    //CanvasManager canvasManager;
    public CanvasType type;
    public CanvasManager mainCanvas;
    public Transform target;
    GameObject mSpawener;
    //DestroyExplButton destroyExplButton;

    void Start()
    {
        backButton = transform.GetComponent<Button>();
        backButton.onClick.AddListener(BackToMainMenu);
        mSpawener = GameObject.FindWithTag("Respawn");
        target = GameObject.FindWithTag("MainCanvas").transform;
    }

    void BackToMainMenu()
    {
        //MOVE MAINCANVAS TO ITS ORIGINAL POSITION IN MENU SCENE AND TURN IT ON TO MAIN MENU
        target.transform.position = new Vector3(5.53f, 3.52f, 11.03f);
        target.transform.GetChild(2).position = new Vector3(5.53f, 3.52f, 11.03f);
        target.GetComponent<Canvas>().enabled = true;
        //CanvasManager.GetInstance().SwitchCanvas(CanvasType.MainMenu);
        mainCanvas = FindObjectOfType<CanvasManager>();
        mainCanvas.SwitchCanvas(CanvasType.MainMenu);

        //DESTROY EXPL BUTTON
        if (target.GetChild(1).GetChild(1).childCount > 2)
        {
            target.GetChild(1).GetChild(1).gameObject.GetComponent<DestroyExplButton>().GetChildAndDestroy();
        }
        else
        {
            Debug.Log("The child is already destroy");
        }

        //MOVE SPAWNER AND DESTROY THE AUDIO
        mSpawener.transform.position = new Vector3(5.66f, -1f, 3.18f);
        mSpawener.GetComponent<MushroomAudio>().DestroyOnExit();

        //Toogle button expl back to default
        mainCanvas.ToogleExplButton();

        Jumpscene(0);
    }

    public void Jumpscene(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        yield return null;
    }
}
