using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CanvasSwitcher : MonoBehaviour
{
    public CanvasType desiredCanvasType;

    CanvasManager canvasManager;
    Button menuButton;

    private void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClick);
        canvasManager = CanvasManager.GetInstance();       
    }

    void OnButtonClick()
    {
        canvasManager.SwitchCanvas(desiredCanvasType);
    }
}
