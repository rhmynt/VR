using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//INI DI VR BUTTON
public class ActiveOnOffWalk : MonoBehaviour
{
    Button vrButton;
    //GameObject vrButtonG;
    public GameObject player;
    public GameObject onOffButton;
    private void Start()
    {
        vrButton = GetComponent<Button>();
        onOffButton.SetActive(true);
        gameObject.SetActive(false);
        vrButton.onClick.AddListener(ButtonWalk);
    }
    
    public void ButtonWalk()
    {
        gameObject.SetActive(false);
        onOffButton.SetActive(true);
        player.GetComponent<VRLookWalk>().enabled = true;
        player.GetComponent<CharacterController>().enabled = true;
        player.GetComponent<PlayerWalk>().enabled = false;
    }
}
