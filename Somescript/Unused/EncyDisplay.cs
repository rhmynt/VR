using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EncyDisplay : MonoBehaviour
{
    public bool isActive = false;
    private void OnEnable()
    {
        isActive = false;
    }
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descText;
    public Image illustSprite;
    public Image illustSprite1;
    public Image illustSprite2;
    public Image illustSprite3;

    [Space]
    public string searchItemID;

    public void GetItemID()
    {
        SetUI(Database.GetItemByID(searchItemID));
        Debug.Log("IDK");
    }

    public void GetItemByTag()
    {

    }

    private void SetUI(EncyData i)
    {
        titleText.text = i.mushroomName;
        descText.text = i.description;
        illustSprite.sprite = i.illust_0;
    }




/*    private void Start()
    {
        titleText.text = encyDesc.encyAll[1].title;
        descText.text = encyDesc.encyAll[1].description;
        illustSprite.sprite = encyDesc.encyAll[1].illust_0;
        //illustSprite1.sprite = data[0].illust_1;
        //illustSprite2.sprite = data[0].illust_2;
    }
*/
}
