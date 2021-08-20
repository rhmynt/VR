using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using System;

[CreateAssetMenu (fileName = "Mushroom", menuName = "Assets/Databases/Items")]
public class EncyData : ScriptableObject
{
    [Header("Keyword")]
    public string itemID;
/*    public enum ItemTag
    {
        Edible,
        Poisonous,
        Medicine
    }

    public ItemTag tag;*/

    public string itemTag;

    public Sprite icon;
    public GameObject mushroom3D;
    public AudioClip clip;
    public AudioSource source;

    [Header("Description")]
    public string mushroomName;
    public string marketName;
    public Vector3 position;
    public Vector3 rotation;

    [Serializable]
    public struct Encyclopedia
    {
        public string title;
        [TextArea(10, 10)]
        public string description;
        public Sprite illust_0;
        public Sprite illust_1;
        public Sprite illust_2;
        public Sprite illust_3;
    }

    
    [SerializeField] public Encyclopedia[] encyAll;
    internal string title;
    internal string description;
    internal Sprite illust_0;
    internal Sprite illust_1;
    internal Sprite illust_2;
    
}
