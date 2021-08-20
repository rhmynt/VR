using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//INI DI ON ONFF BUTTON
public class ActivateVRWalk : MonoBehaviour
{
    Button onOffButton;
    //GameObject onOffButtonG;
    public GameObject player;
    public GameObject vrButton;

    private void Start()
    {
        onOffButton = GetComponent<Button>();
        onOffButton.onClick.AddListener(VRWalk);
    }

    public void VRWalk()
    {
        gameObject.SetActive(false);
        vrButton.SetActive(true);
        player.GetComponent<PlayerWalk>().enabled = true;
        player.GetComponent<VRLookWalk>().enabled = false;
        player.GetComponent<CharacterController>().enabled = false;
    }

}
