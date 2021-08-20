using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SearchDbToUI : MonoBehaviour
{
    public TextMeshProUGUI s_latinName;
    public TextMeshProUGUI S_marketName;
    public TextMeshProUGUI s_tag;
    public Sprite s_sprite;



    [Space]

    public string itemID;

    public void GetByID()
    {
        Debug.Log("Ini sih kebaca");
    }

    public void GetByTag()
    {
        
    }

    public void ShowAll()
    {
        SetUI(Database.GetItemByID(itemID));
    }

    private void SetUI(EncyData i)
    {
        s_latinName.text = i.mushroomName;
        S_marketName.text = i.itemID;
        s_tag.text = i.itemTag;
    }




}
