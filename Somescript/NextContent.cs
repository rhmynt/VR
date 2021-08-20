using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Button))]
public class NextContent : MonoBehaviour
{
    Button nextButton;
    //CanvasManager canvasManager;
    public GameObject pageContent;
    private Component pageNumber;
    
    private void Start()
    {
        nextButton = GetComponent<Button>();
        nextButton.onClick.AddListener(OnButtonClicked);
        //canvasManager = CanvasManager.GetInstance();
        //pageContent = GameObject.Find("Canvas/Explanations/Tab_Panel/ContentPage");
        pageNumber = pageContent.GetComponent("TextMeshProUGUI/Overflow/Page");
    }

    void OnButtonClicked()
    {
        if (pageContent != null)
        { 

            for (int i = 0; i < 5; i++)
            {
                Debug.Log("Nyampe");
            }
            
        }
    }
}
