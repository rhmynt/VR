using UnityEngine;

public class DestroyExplButton : MonoBehaviour
{
    public GameObject objectToFind;
    public GameObject template;
    public void GetChildAndDestroy()
    {
        Transform[] allChildren = this.transform.GetComponentsInChildren<Transform>();
        int length = allChildren.Length;
        Debug.Log("The total of childs are " + length);
        for (int i = 1 ; i < length - (length/2) ; i++)
        {
            Debug.Log("The buttons are " + allChildren[i].name);
            objectToFind = transform.GetChild(i).gameObject;
            Destroy(objectToFind);
        }
        template.SetActive(true);        
    }
}
